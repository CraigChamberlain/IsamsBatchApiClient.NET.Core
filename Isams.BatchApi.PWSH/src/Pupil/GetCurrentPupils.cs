using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.PupilManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "CurrentPupils")]
    [OutputType(typeof(PupilManagerCurrentPupil))]
    public class GetCurrentPupilCommand : GetIsamsCommand
    {
        protected override Method Method => Method.Pupil_GetCurrentPupils;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.PupilManager.CurrentPupils, true);
            base.ProcessRecord();
        }
    }
}