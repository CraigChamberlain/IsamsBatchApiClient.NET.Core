using Xunit;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.Tests.Modules;

namespace Isams.BatchApiClient.Core.Tests.School
{

    public class GetSchoolForms
    {
        private const string path = @"../../../Responses/Examples/School/GetSchoolForms.xml";

        [Fact]
        public void GetSchoolForms_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.SchoolManager.Forms;
#endif
        }
    }

}