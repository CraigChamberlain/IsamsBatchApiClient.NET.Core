using Xunit;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;

namespace Isams.BatchApiClient.Tests.School
{

    public class GetAcademicHouses
    {
        private const string path = @"../../../Responses/Examples/School/GetAcademicHouses.xml";

        [Fact]
        public void GetAcademicHouses_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.SchoolManager.AcademicHouses;
#endif
        }
    }

}