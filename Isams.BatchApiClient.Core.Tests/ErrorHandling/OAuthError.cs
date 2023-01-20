using Isams.BatchApiClient.Core.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Isams.BatchApiClient.Core.Tests.ErrorHandling
{
    // TODO Do testing with Mocks not against live server
    // TODO Put method tests in another Test Class
    public class OAuthError
    {
        [Fact]
        public async Task NoErrorWithValidCredentials()
        {
            var x = await OAuthHttpServices.AsyncCreateServices(KeyData.Host,
                KeyData.ClientID,
                KeyData.ClientSecret);

            var isams = await x.MethodRequestAsync(DTO.Filters.Method.School_GetAcademicHouses);

            x.DisposeAsync().AsTask().Wait();

        }

        [Fact]
        public async Task ErrorWithInvalidCredentials() 
        {
            var e = await Record.ExceptionAsync(
                () => OAuthHttpServices.AsyncCreateServices(
                    KeyData.Host, 
                    Guid.NewGuid().ToString(),
                    Guid.NewGuid().ToString()));

            Assert.IsType<Exception>(e);
            Assert.Equal("invalid_client", e.Message);
        }
    }
}
