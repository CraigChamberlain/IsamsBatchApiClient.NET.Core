using Xunit;
using Isams.BatchApiClient.Core.Services;
using System.Net.Http;

namespace Isams.BatchApiClient.Tests.Tracking
{

    public class HttpQuery
    {
        private const string root = "https://developerdemo.isams.cloud";
        private const string key = "739A1241-EB52-49BF-AB5D-FBCC1E468F5E";

        [Fact]
        public void ComposeUrl()
        {

            var httpServices = ApiKeyHttpServices.CreateServices(root);

            var isams = httpServices.ComposeUrl(key);

            Assert.Equal("https://developerdemo.isams.cloud/api/batch/1.0/xml.ashx?apiKey=739A1241-EB52-49BF-AB5D-FBCC1E468F5E", isams);

        }

    }

}