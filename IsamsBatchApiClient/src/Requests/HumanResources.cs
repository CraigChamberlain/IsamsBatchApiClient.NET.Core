using static IsamsBatchApiClient.DTO.Filters.Method;

namespace IsamsBatchApiClient.Requests
{
    public partial class RequestFactory
    {
        public Filters CreateHumanResources_GetCurrentStaffRequest()
        {
            return new Filters(HumanResources_GetCurrentStaff);
        }
    }
}
