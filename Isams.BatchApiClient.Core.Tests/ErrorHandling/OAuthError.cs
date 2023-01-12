using System.Threading.Tasks;
using Isams.BatchApiClient.Core.Services;
using Xunit;

namespace Isams.BatchApiClient.Core.Tests.ErrorHandling
{
    public class OAuthError
    {
        [Fact]
        public void ErrorHandling()
        {
            var x = OAuthHttpServices.AsyncCreateServices("https://developerdemo.isams.cloud", "IDIDIID", "SECRETSECRET").Result;

        }
    }
}
