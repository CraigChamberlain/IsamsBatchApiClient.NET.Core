using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.PupilManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "Siblings")]
    [OutputType(typeof(SiblingsPupil))]
    public class GetSiblingCommand : GetIsamsCommand
    {
        protected override Method Method => Method.Pupil_GetSiblings;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.PupilManager.Siblings, true);
            base.ProcessRecord();
        }
    }
}