using Xunit;
using IsamsBatchApiClient.Tests.Modules;

namespace IsamsBatchApiClient.Tests.Pupil
{

    public class GetApplicants
    {
        private const string path = @"../../../Responses/Examples/Pupil/GetApplicants.xml";

        [Fact]
        public void GetAlumni_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.PupilManager.Applicants;
            var t = (Model.PupilManager.PupilManagerApplicant)s[0];
#endif
        }
    }
}