using IsamsBatchApiClient.DTO.Filters;
using IsamsBatchApiClient.Model.SchoolManager;
using System.Management.Automation;

namespace IsamsBatchApiClient.PWSH.Commands
{
    [Cmdlet(VerbsCommon.Get, "IsamsBoardingHouse")]
    [OutputType(typeof(House))]
    public class GetIsamsBoardingHouseCommand : GetIsamsCommand
    {
        protected override Method Method => Method.School_GetBoardingHouses;
        protected override void ProcessRecord()
        {   
            WriteObject(_isams.SchoolManager.BoardingHouses, true);
            base.ProcessRecord();
        }
    }
}