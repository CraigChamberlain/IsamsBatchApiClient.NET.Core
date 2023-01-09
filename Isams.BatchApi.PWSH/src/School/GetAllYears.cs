using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.SchoolManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "AllYears")]
    [OutputType(typeof(Year))]
    public class GetAllYears : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetAllYears;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.Years, true);
            base.ProcessRecord();
        }
    }
}