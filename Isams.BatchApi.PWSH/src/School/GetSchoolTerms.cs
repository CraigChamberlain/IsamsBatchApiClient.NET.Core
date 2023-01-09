using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.SchoolManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "SchoolTerms")]
    [OutputType(typeof(Term))]
    public class GetSchoolTermsCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetSchoolTerms;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.Terms, true);
            base.ProcessRecord();
        }
    }
}