using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Requests;

namespace Isams.BatchApiClient.Core.Services
{
    /// <summary>
    /// A class containing services with which to comunicate with the iSAMS batch API.
    /// Instantiate using the <see cref="CreateServices(string, int, Func{int, TimeSpan}, HttpClient)"/> factory method.
    /// </summary>
    public class ApiKeyHttpServices : HttpServices
    {
        private ApiKeyHttpServices(HttpClient client, string apiRoot, Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> retryPolicy)
            : base(client,  apiRoot,  retryPolicy)
        {
        }

        /// <summary>
        /// Factory method to create <see cref="HttpServices"/> instance.
        /// </summary>
        /// <param name="apiRoot">The domain of your iSAMS instance e.g. "https://your-school.isams.cloud". Use the helper method <see cref="ValidateApiRoot(string)"/> to check format.</param>
        /// <param name="maxRetry">The number of times to retry a request which fails with a transient error.</param>
        /// <param name="retrySleepDurationProvider">A funtion to determine the period of incremental retries in the case of a retryable failure.</param>
        /// <param name="client">An optional <see cref="HttpClient"/> instance.  If this is ommited one will be enstantiated.</param>
        /// <returns><see cref="HttpServices"/>.</returns>
        public static ApiKeyHttpServices CreateServices(
                string apiRoot,
                int maxRetry = 5,
                Func<int, TimeSpan> retrySleepDurationProvider = null,
                HttpClient client = null)
        {
            if (client is null)
            {
                client = new HttpClient();
            }

            var policy = CreateDefaultPolicy(maxRetry, retrySleepDurationProvider);

            return new ApiKeyHttpServices(client, apiRoot, policy);
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