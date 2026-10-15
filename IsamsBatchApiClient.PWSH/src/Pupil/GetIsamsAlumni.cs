using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.PupilManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsAlumni")]
    [OutputType(typeof(PupilManagerCurrentPupil))]
    public class GetIsamsAlumniCommand : GetIsamsCommand
    {
        protected override Method Method => Method.Pupil_GetAlumni;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.PupilManager.CurrentPupils, true);
            base.ProcessRecord();
        }
    }
}