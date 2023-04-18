using Xunit;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;

namespace Isams.BatchApiClient.Tests.School
{

    public class GetBoardingHouses
    {
        private const string path = @"../../../Responses/Examples/School/GetBoardingHouses.xml";

        [Fact]
        public void GetBoardingHouses_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.SchoolManager.BoardingHouses;
#endif
        }
    }

}