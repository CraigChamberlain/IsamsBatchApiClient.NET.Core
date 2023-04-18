using Xunit;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;

namespace Isams.BatchApiClient.Tests.Pupil
{

    public class GetSiblings
    {
        private const string path = @"../../../Responses/Examples/Pupil/GetSiblings.xml";

        [Fact]
        public void GetSiblings_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.PupilManager.Siblings;
#endif
        }
    }

}