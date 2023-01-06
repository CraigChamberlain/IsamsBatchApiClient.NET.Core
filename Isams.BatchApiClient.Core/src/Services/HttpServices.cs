using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Errors;
using Isams.BatchApiClient.Core.Requests;
using Polly;

namespace Isams.BatchApiClient.Core.Services
{
    /// <summary>
    /// A class containing services with which to comunicate with the iSAMS batch API.
    /// Instantiate using the <see cref="CreateHttpServices(string, int, Func{int, TimeSpan}, HttpClient)"/> factory method.
    /// </summary>
    public class HttpServices
    {
        private static readonly string api = "/api/batch/1.0/";
        private static readonly string example = @"https://your-school.isams.cloud";
        private static readonly string baseUrlPattern = @"http(s)?://[\w-]+(.[\w-]+)*.\w+";
        private static readonly Regex baseUrlRegex = new (baseUrlPattern);
        private static readonly Func<int, TimeSpan> defaultSleepDurationProvider = times => TimeSpan.FromMilliseconds(100 * times * times);

        private static readonly HashSet<HttpStatusCode> httpStatusCodesWorthRetrying = new ()
        {
           HttpStatusCode.RequestTimeout, // 408

           // HttpStatusCode.InternalServerError, // 500  -- Needs to be handled by reading the reply.
           HttpStatusCode.BadGateway, // 502
           HttpStatusCode.ServiceUnavailable, // 503
           HttpStatusCode.GatewayTimeout, // 504
        };

        private readonly HttpClient _client;
        private readonly string _methodRoot;
        private readonly Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> _policy;

        private HttpServices(HttpClient client, string apiRoot, Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> retryPolicy)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _policy = retryPolicy ?? throw new ArgumentNullException(nameof(retryPolicy));

            if (apiRoot is null)
            {
                throw new ArgumentNullException(nameof(apiRoot));
            }

            var match = baseUrlRegex.Match(apiRoot);

            if (!match.Success)
            {
                throw new ArgumentException(
                    "Pattern should match " +
                    baseUrlPattern +
                    System.Environment.NewLine +
                    "e.g. " + example +
                    System.Environment.NewLine +
                    "Use the helper method ValidateApiRoot to validate your root.");
            }

            _methodRoot = match.Value + api + "xml.ashx?apiKey=";
        }

        /// <summary>
        /// Factory method to create <see cref="HttpServices"/> instance.
        /// </summary>
        /// <param name="apiRoot">The domain of your iSAMS instance e.g. "https://your-school.isams.cloud". Use the helper method <see cref="ValidateApiRoot(string)"/> to check format.</param>
        /// <param name="maxRetry">The number of times to retry a request which fails with a transient error.</param>
        /// <param name="retrySleepDurationProvider">A funtion to determine the period of incremental retries in the case of a retryable failure.</param>
        /// <param name="client">An optional <see cref="HttpClient"/> instance.  If this is ommited one will be enstantiated.</param>
        /// <returns><see cref="HttpServices"/>.</returns>
        public static HttpServices CreateHttpServices(
                string apiRoot,
                int maxRetry = 5,
                Func<int, TimeSpan> retrySleepDurationProvider = null,
                HttpClient client = null)
        {
            if (client is null)
            {
                client = new HttpClient();
            }

            if (retrySleepDurationProvider is null)
            {
                retrySleepDurationProvider = defaultSleepDurationProvider;
            }

            var policy =
                Policy
                    .Handle<HttpRequestException>()
                    .Or<RecoverableException>()
                    .OrResult<HttpResponseMessage>(r => httpStatusCodesWorthRetrying.Contains(r.StatusCode))
                    .WaitAndRetryAsync(maxRetry, retrySleepDurationProvider);

            return new HttpServices(client, apiRoot, policy);
        }

        /// <summary>
        /// Helper to determine if ApiRoot matches required pattern.
        /// </summary>
        /// <param name="apiRoot">The ApiRoot you intend to validate.</param>
        /// <returns><c>bool</c> value to indicate if the provided string is valid.</returns>
        public static bool ValidateApiRoot(string apiRoot)
        {
            return baseUrlRegex.IsMatch(apiRoot);
        }

        /// <summary>
        /// Helper to produce a complete and valid Url by appending the given an Api key as a query string.
        /// </summary>
        /// <param name="key">The Api key for the endpoint you wish to target. e.g. "A25F7D3B-5CF5-4DAC-A33B-3305562261C2".</param>
        /// <returns>The Api root appended by the key. e.g. "https://your-school.isams.cloud/api/batch/1.0/xml.ashx?apiKey=A25F7D3B-5CF5-4DAC-A33B-3305562261C2".</returns>
        public string ComposeUrl(string key)
        {
            return _methodRoot + key;
        }

        public async Task<Stream> PostRequestAsync(string url, StreamContent body = null)
        {
            var message = await _policy.ExecuteAsync(async () =>
                {
                    var resp = await _client.PostAsync(url, body);
                    if (
                        resp.StatusCode == HttpStatusCode.InternalServerError || // Lock related Errors
                        resp.StatusCode == HttpStatusCode.Forbidden || // MethodsNotAllocatedToKeyException
                        resp.StatusCode == HttpStatusCode.Unauthorized) // InvalidApiKey
                    {
                        throw await ApiErrorHandler.ErrorFromStream(await resp.Content.ReadAsStreamAsync());
                    }

                    return resp;
                });

#if DEBUG
            var str = await message.Content.ReadAsStringAsync();
#endif
            if (!message.IsSuccessStatusCode)
            {
                throw new HttpRequestException(message.StatusCode.ToString(), null, message.StatusCode);
            }

            return await message.Content.ReadAsStreamAsync();
        }

        public async Task<Stream> PostRequestAsync(string url, Stream body)
        {
            return await PostRequestAsync(url, new StreamContent(body));
        }

        public async Task<Collections.Isams> MethodRequestAsync(Method method, string key, Deserialiser deserialiser, RequestSeserialiser requestSeserialiser)
        {
            return await MethodRequestAsync(new Filters(method), key, deserialiser, requestSeserialiser);
        }

        public async Task<Collections.Isams> MethodRequestAsync(string key, Deserialiser deserialiser, StreamContent body = null)
        {
            var url = ComposeUrl(key);
            var response = await PostRequestAsync(url, body);
#if DEBUG
            StreamReader sr = new (response);
            var s = sr.ReadToEnd();
            response.Position = 0;
#endif

            // TODO try catch? Should not happen unless fatal error?
            // Maybe should be popped in an error rather than an exception.
            var isams = deserialiser.DeserialiseStream(response);
            return isams;
        }

        public async Task<Collections.Isams> MethodRequestAsync(Filters filters, string key, Deserialiser deserialiser, RequestSeserialiser requestSeserialiser)
        {
            MemoryStream ms = new ();
            requestSeserialiser.SerialiseToStream(ms, filters);
            return await MethodRequestAsync(key, deserialiser, new StreamContent(ms));
        }
    }
}