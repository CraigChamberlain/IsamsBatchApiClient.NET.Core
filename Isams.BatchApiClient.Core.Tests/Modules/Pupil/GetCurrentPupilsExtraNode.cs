using Xunit;
using System;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;

namespace Isams.BatchApiClient.Core.Tests.Pupil
{

    public class GetCurrentPupilsExtraNode
    {
        private const string path = @"../../../Responses/Examples/Pupil/GetCurrentPupilsExtraNode.xml";

        [Fact]
        public void GetCurrentPupilsExtra_ShouldThrowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            Assert.Throws<InvalidOperationException>(() => deserialiser.DeserialiseStream(stream));
        }

        [Fact]
        public void GetCurrentPupilsExtra_ShouldNotThrowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Deserialiser.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.PupilManager.CurrentPupils;
            var t = (Model.PupilManager.PupilManagerCurrentPupil)s[0];
#endif
        }

    }
}