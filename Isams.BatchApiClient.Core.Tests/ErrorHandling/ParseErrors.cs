using Isams.BatchApiClient.Core.Services;
using Xunit;
using System.Threading.Tasks;
using System.IO;

namespace Isams.BatchApiClient.Tests.ErrorHandling;

public class ParseErrors
{
    [Fact]
    public async Task GivenXmlError_ErrorFromStream_ThenReturnWellFormedError()
    {
        using (var errorStream = File.OpenRead(@"../../../Responses/Examples/Errors/Deadlock.xml"))
        {
            var e = await ApiErrorHandler.ErrorFromStream(errorStream);
            Assert.Equal($"Unknown Error:{System.Environment.NewLine}Transaction (Process ID 118) was deadlocked on lock resources with another process and has been chosen as the deadlock victim. Rerun the transaction.", e.Message);
        }

        using (var errorStream = File.OpenRead(@"../../../Responses/Examples/Errors/LockRequestTimeOut.xml"))
        {
            var e = await ApiErrorHandler.ErrorFromStream(errorStream);
            Assert.Equal($"Unknown Error:{System.Environment.NewLine}Lock request time out period exceeded.  The statement has been terminated.", e.Message);
        }
    }
}