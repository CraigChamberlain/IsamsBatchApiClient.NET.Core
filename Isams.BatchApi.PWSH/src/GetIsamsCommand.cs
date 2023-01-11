using System;
using System.Management.Automation;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.DTO.Filters;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet("Get", "GetIsamsCommand", DefaultParameterSetName = "OAuth")]
    public abstract class GetIsamsCommand : PSCmdlet
    {
        // TODO can they be readonly fields?
        
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ApiKey")]
        public string ApiKey { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ApiKey")]
        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "OAuth")]
        public string IsamsInstance { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "OAuth")]
        public string ClientId { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "OAuth")]
        public string ClientSecret { get; set; }

        private ApiKeyHttpServices _apiKeyDataService;
        private OAuthHttpServices _oAuthDataService;
        private Deserialiser _deserialiser;
        private RequestSeserialiser _serialiser;
        protected abstract Method Method { get; }
        protected BatchApiClient.Core.Collections.Isams _isams;


        protected override void BeginProcessing()
        {
            if (this.ParameterSetName.Equals("ApiKey")){
                _apiKeyDataService = ApiKeyHttpServices.CreateServices(IsamsInstance);
            }
            else
            {
                _oAuthDataService = OAuthHttpServices.CreateServices(IsamsInstance, ClientId, ClientSecret);
            }
            _deserialiser = Deserialiser.CreateDeserialiser();
            _serialiser = RequestSeserialiser.CreateSerialiser();
            try
            {
                if (this.ParameterSetName.Equals("ApiKey"))
                {
                    _isams = _apiKeyDataService.MethodRequestAsync(Method, ApiKey, _deserialiser, _serialiser).Result;
                }
                else
                {
                    _isams = _oAuthDataService.MethodRequestAsync(Method, _deserialiser, _serialiser).Result;
                }
                
            }
            catch (Exception e) {

                WriteWarning(e.Message);
            }
            
            if (_isams is null)
            {
                WriteWarning("Error returning result from API, root is null");
            }

            base.BeginProcessing();
        }
    }
}

