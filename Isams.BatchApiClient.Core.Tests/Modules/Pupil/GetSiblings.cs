using Xunit;
using Isams.BatchApiClient.Core.Services;

namespace Isams.BatchApiClient.Tests.Pupil
{

    public class GetSiblings
    {
        private const string path = @"../../../Responses/Examples/Pupil/GetSiblings.xml";

        [Fact]
        public void GetSiblings_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Deserialiser.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.PupilManager.Siblings;
#endif
        }
    }

}