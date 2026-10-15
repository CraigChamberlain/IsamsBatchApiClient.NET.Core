using static IsamsBatchApiClient.DTO.Filters.Method;

namespace IsamsBatchApiClient.Requests
{
    public partial class RequestFactory
    {
        public Filters CreatePupil_GetCurrentPupilsRequest()
        {
            return new Filters(Pupil_GetCurrentPupils);
        }

        public Filters CreatePupil_GetSiblingsRequest()
        {
            return new Filters(Pupil_GetSiblings);
        }
    }
}
