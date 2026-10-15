using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.SchoolManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsSchoolYear")]
    [OutputType(typeof(Year))]
    public class GetIsamsSchoolYearCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetAllYears;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.Years, true);
            base.ProcessRecord();
        }
    }
}