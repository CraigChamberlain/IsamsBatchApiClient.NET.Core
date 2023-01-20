using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Requests;

namespace Isams.BatchApiClient.Core.Services
{
    /// <summary>
    /// A class containing services with which to comunicate with the iSAMS batch API.
    /// Instantiate using the <see cref="CreateHttpServices(string, int, Func{int, TimeSpan}, HttpClient)"/> factory method.
    /// </summary>
    public class OAuthHttpServices : HttpServices, IAsyncDisposable
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private string _accessToken;
        private string _methodUrl;
        private DateTime _tokenExpiry;

        private readonly TimeSpan _gracePeriod = new TimeSpan(50000000);

        private OAuthHttpServices(
            HttpClient client,
            string apiRoot,
            string clientID,
            string clientSecret,
            Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> retryPolicy,
            Deserialiser deserialiser,
            RequestSeserialiser requestSeserialiser)
        : base(client, apiRoot, retryPolicy, deserialiser, requestSeserialiser)
        {
            _clientId = clientID;
            _clientSecret = clientSecret;
            _methodUrl = base.ComposeUrl(clientID);
        }

        /// <summary>
        /// Factory method to create <see cref="HttpServices"/> instance.
        /// </summary>
        /// <param name="apiRoot">The domain of your iSAMS instance e.g. "https://your-school.isams.cloud". Use the helper method <see cref="ValidateApiRoot(string)"/> to check format.</param>
        /// <param name="maxRetry">The number of times to retry a request which fails with a transient error.</param>
        /// <param name="retrySleepDurationProvider">A funtion to determine the period of incremental retries in the case of a retryable failure.</param>
        /// <param name="client">An optional <see cref="HttpClient"/> instance, it must be configured with a handler to process the OAuth Hedders.  If this is ommited one will be enstantiated.</param>
        /// <returns><see cref="HttpServices"/>.</returns>
        public static async Task<OAuthHttpServices> AsyncCreateServices(
                string apiRoot,
                string clientID,
                string clientSecret,
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

            var services = new OAuthHttpServices(
                client,
                apiRoot,
                clientID,
                clientSecret,
                policy,
                deserialiser,
                requestSeserialiser);

            await services.AcquireToken();

            return services;
        }

        private async Task AcquireToken(){
            var request = new ClientCredentialsTokenRequest
                    {
                        Address = _apiRoot + "/auth/connect/token",
                        ClientId = _clientId,
                        ClientSecret = _clientSecret,
                        Scope = "apiv1"
                    };

            var requestTime = DateTime.Now;
            // TODO add retry policy?
            var response = await _client.RequestClientCredentialsTokenAsync(request);

            if (response.IsError)
            {
                throw new Exception(response.Error);
            }

            _accessToken = response.AccessToken;
            _tokenExpiry = requestTime.AddSeconds(response.ExpiresIn);

            _client.SetBearerToken(response.AccessToken);
        }

        private async Task RevokeToken()
        {

            if (this.TokenExpired())
            {
                return;
            }

            var response = await _client.RevokeTokenAsync(
                new TokenRevocationRequest
                {
                                Address = _apiRoot + "/auth/connect/revocation",
                                ClientId = _clientId,
                                ClientSecret = _clientSecret,

                                Token = _accessToken
                });

            if (response.IsError) throw new Exception(response.Error);
        }

        private Boolean TokenExpired(){
            return _tokenExpiry.Subtract(DateTime.Now) < _gracePeriod;
        }

        public async Task<Collections.Isams> MethodRequestAsync(Method method)
        {
            return await MethodRequestAsync(new Filters(method));
        }

        public async Task<Collections.Isams> MethodRequestAsync(StreamContent body = null)
        {
            // Renew if required
            if (this.TokenExpired()) {
                await this.AcquireToken();
            }

            var response = await this.PostRequestAsync(_methodUrl, body);
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

        public async Task<Collections.Isams> MethodRequestAsync(Filters filters)
        {
            MemoryStream ms = new ();
            _requestSeserialiser.SerialiseToStream(ms, filters);
            return await MethodRequestAsync(new StreamContent(ms));
        }

        public ValueTask DisposeAsync()
        {
            return new ValueTask(RevokeToken());
        }
    }
}