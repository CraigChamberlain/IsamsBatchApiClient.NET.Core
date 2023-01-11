using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.SchoolManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsSchoolForm")]
    [OutputType(typeof(Form))]
    public class GetIsamsSchoolFormCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetSchoolForms;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.Forms, true);
            base.ProcessRecord();
        }
    }
}