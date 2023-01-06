using static Isams.BatchApiClient.Core.DTO.Filters.Method;

namespace Isams.BatchApiClient.Core.Requests
{
    public partial class RequestFactory
    {
        public Filters CreateHumanResources_GetCurrentStaffRequest()
        {
            return new Filters(HumanResources_GetCurrentStaff);
        }
    }
}
