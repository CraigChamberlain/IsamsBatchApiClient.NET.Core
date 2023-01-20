using System;
using System.Management.Automation;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.DTO.Filters;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet("Get", "GetIsamsCommand", DefaultParameterSetName = Constants.OAUTH)]
    public abstract class GetIsamsCommand : PSCmdlet
    {
        // TODO can they be readonly fields?
        
        [Parameter(Position = 0, ParameterSetName = Constants.API_KEY)]
        public string ApiKey { get; set; }

        [Parameter(Position = 1, ParameterSetName = Constants.API_KEY)]
        public string IsamsInstance { get; set; }

        private ApiKeyHttpServices _apiKeyDataService;

        protected abstract Method Method { get; }
        protected BatchApiClient.Core.Collections.Isams _isams;


        protected override void BeginProcessing()
        {
            var state = (ModuleState)SessionState.PSVariable.GetValue(Constants.stateVariable);
        
            try
            {
                if (
                    this.ParameterSetName == Constants.API_KEY ||  
                    state is not null && state.ConnectionModel == ConnectionModel.API_KEY )
                {
                    if(state is null || state.ApiKeyDataServices is null){
                        _apiKeyDataService = ApiKeyHttpServices.CreateServices(IsamsInstance);
                    }
                    else {
                        _apiKeyDataService = state.ApiKeyDataServices;
                    }
                    if(string.IsNullOrEmpty(ApiKey)){
                        ApiKey = state.DefaultApiKey;
                    }
                    _isams = _apiKeyDataService.MethodRequestAsync(Method, ApiKey).Result;
                }
                else
                {
                    if(state is null || state.OAuthHttpServices is null){
                        throw new Exception("Use Connect-Isams prior to using in OAuth Mode");
                    }
                    else {
                        _isams = state.OAuthHttpServices.MethodRequestAsync(Method).Result;
                    }
                    
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

