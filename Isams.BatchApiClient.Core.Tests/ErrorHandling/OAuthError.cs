using Isams.BatchApiClient.Core.Services;
using Xunit;

namespace Isams.BatchApiClient.Core.Tests.ErrorHandling
{
    public class OAuthError
    {
        [Fact]
        public void ErrorHandling()
        {
            var x = OAuthHttpServices.CreateServices( 
                KeyData.Host, 
                KeyData.ClientID, 
                KeyData.ClientSecret );

        }
    }
}
