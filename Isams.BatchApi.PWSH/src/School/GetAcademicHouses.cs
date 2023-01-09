using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.SchoolManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "AcademicHouses")]
    [OutputType(typeof(House))]
    public class GetAcademicHousesCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetAcademicHouses;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.AcademicHouses, true);
            base.ProcessRecord();
        }
    }
}