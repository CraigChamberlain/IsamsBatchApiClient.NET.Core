using Xunit;
using Isams.BatchApiClient.Core.Services;

namespace Isams.BatchApiClient.Tests.School
{

    public class GetAllYears
    {
        private const string path = @"../../../Responses/Examples/School/GetAllYears.xml";

        [Fact]
        public void GetAllYears_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Deserialiser.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.SchoolManager.Years;
#endif
        }
    }

}