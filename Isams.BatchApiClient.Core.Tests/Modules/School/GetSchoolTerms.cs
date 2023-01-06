using Xunit;
using Isams.BatchApiClient.Core.Services;

namespace Isams.BatchApiClient.Tests.School;

public class GetSchoolTerms
{
    private const string path = @"../../../Responses/Examples/School/GetSchoolTerms.xml";

    [Fact]
    public void GetSchoolTerms_ShouldNotThowException()
    {
        using var stream = System.IO.File.OpenRead(path);
        var deserialiser = Deserialiser.CreateDeserialiser();
        var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
        var s = active.SchoolManager.Terms;
#endif
    }
}

