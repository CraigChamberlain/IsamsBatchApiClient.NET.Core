using Isams.BatchApiClient.Core.DTO.Filters;
using Isams.BatchApiClient.Core.Model.SchoolManager;
using System.Management.Automation;

namespace Isams.BatchApi.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "BoardingHouses")]
    [OutputType(typeof(House))]
    public class GetBoardingHousesCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetBoardingHouses;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.BoardingHouses, true);
            base.ProcessRecord();
        }
    }
}