using Xunit;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;

namespace Isams.BatchApiClient.Tests.School
{

    public class GetSchoolDivisions
    {
        private const string path = @"../../../Responses/Examples/School/GetSchoolDivisions.xml";

        [Fact]
        public void GetSchoolDivisions_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.SchoolManager.SchoolDivisions;
#endif
        }
    }

}