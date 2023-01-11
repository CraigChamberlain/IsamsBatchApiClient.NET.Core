using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.SchoolManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
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