using static Isams.BatchApiClient.Core.DTO.Filters.Method;

namespace Isams.BatchApiClient.Core.Requests
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
