using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.HRManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsCurrentStaff")]
    [OutputType(typeof(StaffMember))]
    public class GetIsamsCurrentStaffCommand : GetIsamsCommand
    {
        protected override Method Method => Method.HumanResources_GetCurrentStaff;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.HRManager.CurrentStaff, true);
            base.ProcessRecord();
        }
    }
}