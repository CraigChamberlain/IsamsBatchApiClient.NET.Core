using Xunit;
using IsamsBatchApiClient.Services;
using IsamsBatchApiClient.Tests.Modules;

namespace IsamsBatchApiClient.Tests.School
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