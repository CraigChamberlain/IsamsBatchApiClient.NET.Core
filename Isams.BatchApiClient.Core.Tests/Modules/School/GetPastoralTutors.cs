using Xunit;
using Isams.BatchApiClient.Core.Services;

namespace Isams.BatchApiClient.Tests.School
{

    public class GetPastoralTutors
    {
        private const string path = @"../../../Responses/Examples/School/GetPastoralTutors.xml";

        [Fact]
        public void GetPastoralTutors_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Deserialiser.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.SchoolManager.PastoralTutors;
#endif
        }
    }

}