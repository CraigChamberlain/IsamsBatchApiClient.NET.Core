using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.SchoolManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsPastoralTutor")]
    [OutputType(typeof(StaffMemberId))]
    public class GetIsamsPastoralTutorCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetPastoralTutors;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.PastoralTutors, true);
            base.ProcessRecord();
        }
    }
}