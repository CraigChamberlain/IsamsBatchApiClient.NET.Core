using Xunit;
using IsamsBatchApiClient.Services;
using IsamsBatchApiClient.Tests.Modules;

namespace IsamsBatchApiClient.Tests.HumanResources
{

    public class GetCurrentStaff
    {
        private const string path = @"../../../Responses/Examples/HumanResources/GetCurrentStaff.xml";

        [Fact]
        public void GetCurrentStaff_ShouldNotThowException()
        {
            using var stream = System.IO.File.OpenRead(path);
            var deserialiser = Util.CreateDeserialiser();
            var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
            var s = active.HRManager.CurrentStaff;
            var t = (Model.HRManager.StaffMember)s[0];
#endif
        }
    }
}