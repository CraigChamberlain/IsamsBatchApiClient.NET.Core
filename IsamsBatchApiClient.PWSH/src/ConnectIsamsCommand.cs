using System;
using System.Management.Automation;
using IsamsBatchApiClient.Services;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet("Connect", "Isams", DefaultParameterSetName = Constants.OAUTH)]
    public class ConnectIsamsCommand : PSCmdlet
    {      
        
        [Parameter(Mandatory = true, Position = 1, ParameterSetName = Constants.OAUTH )]
        public string IsamsInstance { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = Constants.OAUTH )]
        public string ClientId { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = Constants.OAUTH )]
        public string ClientSecret { get; set; }



        private OAuthHttpServices OAuthDataService;

        protected override void BeginProcessing()
        {
            
            OAuthDataService = OAuthHttpServices.AsyncCreateServices(IsamsInstance, ClientId, ClientSecret).Result;
           

            var connectionModel = Enum.Parse<ConnectionModel>(ParameterSetName);
            var state = new ModuleState(
                connectionModel,
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

