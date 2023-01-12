using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet("Disconnect", "Isams")]
    public class DisconnectIsamsCommand : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            var state = (ModuleState)SessionState.PSVariable.GetValue(Constants.stateVariable);

            if(state.OAuthHttpServices is not null){
                state.OAuthHttpServices.DisposeAsync().AsTask().Wait();
            }

            SessionState.PSVariable.Remove(Constants.stateVariable);

            base.BeginProcessing();
        }
    }
}

