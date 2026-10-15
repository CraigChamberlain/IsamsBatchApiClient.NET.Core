using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.SchoolManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsSchoolTerm")]
    [OutputType(typeof(Term))]
    public class GetIsamsSchoolTermCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetSchoolTerms;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.Terms, true);
            base.ProcessRecord();
        }
    }
}