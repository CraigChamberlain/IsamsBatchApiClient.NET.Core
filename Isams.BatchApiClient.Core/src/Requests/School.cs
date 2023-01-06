using static Isams.BatchApiClient.Core.DTO.Filters.Method;

namespace Isams.BatchApiClient.Core.Requests
{
    public partial class RequestFactory
    {
        public Filters CreateSchool_GetAcademicHousesRequest()
        {
            return new Filters(School_GetAcademicHouses);
        }

        public Filters CreateSchool_GetBoardingHousesRequest()
        {
            return new Filters(School_GetBoardingHouses);
        }

        public Filters CreateSchool_GetSchoolFormsRequest()
        {
            return new Filters(School_GetSchoolForms);
        }

        public Filters CreateSchool_GetPastoralTutorsRequest()
        {
            return new Filters(School_GetPastoralTutors);
        }

        public Filters CreateSchool_GetSchoolDivisionsRequest()
        {
            return new Filters(School_GetSchoolDivisions);
        }

        public Filters CreateSchool_GetSchoolTermsRequest()
        {
            return new Filters(School_GetSchoolTerms);
        }

        public Filters CreateSchool_GetAllYearsRequest()
        {
            return new Filters(School_GetAllYears);
        }
    }
}
