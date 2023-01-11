using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.SchoolManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsSchoolDivision")]
    [OutputType(typeof(SchoolDivision))]
    public class GetIsamsSchoolDivisionCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetSchoolDivisions;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.SchoolDivisions, true);
            base.ProcessRecord();
        }
    }
}