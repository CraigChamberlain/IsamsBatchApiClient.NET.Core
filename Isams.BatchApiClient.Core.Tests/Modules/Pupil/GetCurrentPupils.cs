using Xunit;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;

namespace Isams.BatchApiClient.Core.Tests.Pupil
{

    public class GetCurrentPupils
    {
        private const string path = @"../../../Responses/Examples/Pupil/GetCurrentPupils.xml";

        [Fact]
        public void GetCurrentPupils_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.PupilManager.CurrentPupils;
            var t = (Model.PupilManager.PupilManagerCurrentPupil)s[0];
#endif
        }
    }
}