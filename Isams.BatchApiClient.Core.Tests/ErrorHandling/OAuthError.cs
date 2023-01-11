using Isams.BatchApiClient.Core.Services;
using Xunit;

namespace Isams.BatchApiClient.Core.Tests.ErrorHandling
{
    public class OAuthError
    {
        [Fact]
        public void ErrorHandling()
        {
            var x = OAuthHttpServices.CreateServices("https://developerdemo.isams.cloud", "IDIDIID", "SECRETSECRET");

        }
    }
}
