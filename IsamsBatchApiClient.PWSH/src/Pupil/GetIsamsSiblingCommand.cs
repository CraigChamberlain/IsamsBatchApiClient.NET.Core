using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.PupilManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsSibling")]
    [OutputType(typeof(SiblingsPupil))]
    public class GetIsamsSiblingCommand : GetIsamsCommand
    {
        protected override Method Method => Method.Pupil_GetSiblings;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.PupilManager.Siblings, true);
            base.ProcessRecord();
        }
    }
}