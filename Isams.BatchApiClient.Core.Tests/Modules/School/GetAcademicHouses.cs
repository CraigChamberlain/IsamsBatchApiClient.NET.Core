using Xunit;
using Isams.BatchApiClient.Core.Services;

namespace Isams.BatchApiClient.Tests.School;

public class GetAcademicHouses
{
    private const string path = @"../../../Responses/Examples/School/GetAcademicHouses.xml";

    [Fact]
    public void GetAcademicHouses_ShouldNotThowException()
    {
        using var stream = System.IO.File.OpenRead(path);
        var deserialiser = Deserialiser.CreateDeserialiser();
        var active = deserialiser.DeserialiseStream(stream);
#if DEBUG
        var s = active.SchoolManager.AcademicHouses;
#endif
    }
}

