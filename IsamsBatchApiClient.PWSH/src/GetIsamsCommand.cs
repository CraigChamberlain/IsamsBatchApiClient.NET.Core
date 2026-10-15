using System;
using System.Management.Automation;
using IsamsBatchApiClient.Services;
using IsamsBatchApiClient.DTO.Filters;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet("Get", "GetIsamsCommand", DefaultParameterSetName = Constants.OAUTH)]
    public abstract class GetIsamsCommand : PSCmdlet
    {
        // TODO can they be readonly fields?
        
        [Parameter(Position = 0, ParameterSetName = Constants.API_KEY)]
        public string ApiKey { get; set; }

        [Parameter(Position = 1, ParameterSetName = Constants.API_KEY)]
        public string IsamsInstance { get; set; }

        protected abstract Method Method { get; }
        protected IsamsBatchApiClient.Collections.Isams _isams;


        protected override void BeginProcessing()
        {
            var state = (ModuleState)SessionState.PSVariable.GetValue(Constants.stateVariable);
        
            try
            {
               
               if(state is null || state.OAuthHttpServices is null){
                        var e = new Exception("Use Connect-Isams prior to using in OAuth Mode");
                        ThrowTerminatingError(new ErrorRecord(e, e.Message, 0, state));
                    }
                else {
                    _isams = state.OAuthHttpServices.MethodRequestAsync(Method).Result;
                }
                    
                if (_isams is null)
                {
                    var e = new Exception("Error returning result from API, root is null");
                    ThrowTerminatingError(new ErrorRecord(e, e.Message, 0, state));
                }

            }
            catch (Exception e) {

                WriteError(new ErrorRecord(e,"UnknownError",0, state));
            }
    
            base.BeginProcessing();
        }
    }
}

