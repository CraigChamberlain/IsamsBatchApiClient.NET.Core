using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.PupilManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsApplicant")]
    [OutputType(typeof(PupilManagerCurrentPupil))]
    public class GetIsamsApplicantCommand : GetIsamsCommand
    {
        protected override Method Method => Method.Pupil_GetApplicants;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.PupilManager.CurrentPupils, true);
            base.ProcessRecord();
        }
    }
}