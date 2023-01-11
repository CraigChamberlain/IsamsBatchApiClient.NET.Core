using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using DotNetOpenAuth.OAuth2;
using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Requests;

namespace Isams.BatchApiClient.Core.Services
{
    /// <summary>
    /// A class containing services with which to comunicate with the iSAMS batch API.
    /// Instantiate using the <see cref="CreateHttpServices(string, int, Func{int, TimeSpan}, HttpClient)"/> factory method.
    /// </summary>
    public class OAuthHttpServices : HttpServices
    {
        private OAuthHttpServices(HttpClient client, string apiRoot, Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> retryPolicy)
        : base(client, apiRoot, retryPolicy)
        {
        }

        /// <summary>
        /// Factory method to create <see cref="HttpServices"/> instance.
        /// </summary>
        /// <param name="apiRoot">The domain of your iSAMS instance e.g. "https://your-school.isams.cloud". Use the helper method <see cref="ValidateApiRoot(string)"/> to check format.</param>
        /// <param name="maxRetry">The number of times to retry a request which fails with a transient error.</param>
        /// <param name="retrySleepDurationProvider">A funtion to determine the period of incremental retries in the case of a retryable failure.</param>
        /// <param name="client">An optional <see cref="HttpClient"/> instance, it must be configured with a handler to process the OAuth Hedders.  If this is ommited one will be enstantiated.</param>
        /// <returns><see cref="HttpServices"/>.</returns>
        public static OAuthHttpServices CreateServices(
                string apiRoot,
                string clientID,
                string clientSecret,
                int maxRetry = 5,
                Func<int, TimeSpan> retrySleepDurationProvider = null)
        {
            AuthorizationServerDescription authServer = new ();
            authServer.TokenEndpoint = new Uri(apiRoot);

            var oathService = new WebServerClient(authServer, clientID, clientSecret);
            var accessToken = oathService.GetClientAccessToken(new string[] { "apiv1" });

            // TODO throw some error if the token is no good.

            var handler = oathService.CreateAuthorizingHandler(accessToken);

            // TODO should have a version that allows for dependency injection/HttpClientFactory
            var client = new HttpClient(handler);

            var policy = CreateDefaultPolicy(maxRetry, retrySleepDurationProvider);

            return new OAuthHttpServices(client, apiRoot, policy);
        }

        public async Task<Collections.Isams> MethodRequestAsync(Method method, Deserialiser deserialiser, RequestSeserialiser requestSeserialiser)
        {
            return await MethodRequestAsync(new Filters(method), deserialiser, requestSeserialiser);
        }

        public async Task<Collections.Isams> MethodRequestAsync(Deserialiser deserialiser, StreamContent body = null)
        {
            var response = await PostRequestAsync(_methodRoot, body);
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

        public async Task<Collections.Isams> MethodRequestAsync(Filters filters, Deserialiser deserialiser, RequestSeserialiser requestSeserialiser)
        {
            MemoryStream ms = new ();
            requestSeserialiser.SerialiseToStream(ms, filters);
            return await MethodRequestAsync(deserialiser, new StreamContent(ms));
        }
    }
}