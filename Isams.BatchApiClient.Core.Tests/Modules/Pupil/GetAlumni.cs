using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using Xunit;

namespace Isams.BatchApiClient.Core.Tests.Pupil
{

    public class GetAlumni
    {
        private const string path = @"../../../Responses/Examples/Pupil/GetAlumni.xml";

        [Fact]
        public void GetAlumni_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.PupilManager.Alumni;
            var t = (Model.PupilManager.PupilManagerAlumni)s[0];
            //t.EmailAddress
#endif
        }
    }
}