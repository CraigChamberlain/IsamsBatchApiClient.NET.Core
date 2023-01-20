using System;
using System.Management.Automation;
using Isams.BatchApiClient.Core.Services;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet("Connect", "Isams", DefaultParameterSetName = Constants.OAUTH)]
    public class ConnectIsamsCommand : PSCmdlet
    {
        // TODO can they be readonly fields?
        
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = Constants.API_KEY )]
        public string DefaultApiKey { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = Constants.API_KEY )]
        [Parameter(Mandatory = true, Position = 1, ParameterSetName = Constants.OAUTH )]
        public string IsamsInstance { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = Constants.OAUTH )]
        public string ClientId { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = Constants.OAUTH )]
        public string ClientSecret { get; set; }



        private ApiKeyHttpServices _apiKeyDataService;
        private OAuthHttpServices OAuthDataService;

        protected override void BeginProcessing()
        {
            if (ParameterSetName == Constants.API_KEY ){
                _apiKeyDataService = ApiKeyHttpServices.CreateServices(IsamsInstance);
            }
            else
            {
                OAuthDataService = OAuthHttpServices.AsyncCreateServices(IsamsInstance, ClientId, ClientSecret).Result;
            }

            var connectionModel = Enum.Parse<ConnectionModel>(ParameterSetName);
            var state = new ModuleState(
                connectionModel,
                DefaultApiKey,
                _apiKeyDataService,
                OAuthDataService        
            );
            
            
            var currentState = (ModuleState)SessionState.PSVariable.GetValue(Constants.stateVariable);

            if(currentState is not null && currentState.OAuthHttpServices is not null){
                   currentState.OAuthHttpServices.DisposeAsync().AsTask().Wait();
                }

            SessionState.PSVariable.Set(Constants.stateVariable, state);

            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {   
            base.ProcessRecord();
        }
    }

    
}

