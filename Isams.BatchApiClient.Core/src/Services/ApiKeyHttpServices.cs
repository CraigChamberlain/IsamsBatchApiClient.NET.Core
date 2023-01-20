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
        private ApiKeyHttpServices(
            HttpClient client,
            string apiRoot,
            Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> retryPolicy,
            Deserialiser deserialiser,
            RequestSeserialiser requestSeserialiser)
        : base(client, apiRoot, retryPolicy, deserialiser, requestSeserialiser)
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
                HttpClient client = null,
                Deserialiser deserialiser = null,
                RequestSeserialiser requestSeserialiser = null)
        {
            if (client is null)
            {
                client = new HttpClient();
            }

            if (deserialiser is null)
            {
                deserialiser = Deserialiser.CreateDeserialiser();
            }

            if (requestSeserialiser is null)
            {
                requestSeserialiser = RequestSeserialiser.CreateSerialiser();
            }


            var policy = CreateDefaultPolicy(maxRetry, retrySleepDurationProvider);

            return new ApiKeyHttpServices(
                client,
                apiRoot,
                policy,
                deserialiser,
                requestSeserialiser
                );
        }

        public async Task<Collections.Isams> MethodRequestAsync(Method method, string key)
        {
            return await MethodRequestAsync(new Filters(method), key);
        }

        public async Task<Collections.Isams> MethodRequestAsync(string key, StreamContent body = null)
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
            var isams = _deserialiser.DeserialiseStream(response);
            return isams;
        }

        public async Task<Collections.Isams> MethodRequestAsync(Filters filters, string key)
        {
            MemoryStream ms = new ();
            _requestSeserialiser.SerialiseToStream(ms, filters);
            return await MethodRequestAsync(key, new StreamContent(ms));
        }
    }
}