using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.SchoolManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsAcademicHouse")]
    [OutputType(typeof(House))]
    public class GetIsamsAcademicHouseCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetAcademicHouses;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.AcademicHouses, true);
            base.ProcessRecord();
        }
    }
}