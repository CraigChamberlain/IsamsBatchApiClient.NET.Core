using System;
using System.Management.Automation;
using Isams.BatchApiClient.Core.Services;
using Isams.BatchApiClient.Core.DTO.Filters;

namespace Isams.BatchApi.PWSH.Commands
{
    public abstract class GetIsamsCommand : PSCmdlet
    {
        // TODO can they be readonly fields?
        [Parameter(Mandatory = true, Position = 0)]
        public string ApiKey { get; set; }

        [Parameter(Mandatory = true, Position = 1)]
        public string IsamsInstance { get; set; }

        private HttpServices _dataService;
        private Deserialiser _deserialiser;
        private RequestSeserialiser _serialiser;
        protected abstract Method Method { get; }
        protected BatchApiClient.Core.Collections.Isams _isams;


        protected override void BeginProcessing()
        {
            _dataService = HttpServices.CreateHttpServices(IsamsInstance);
            _deserialiser = Deserialiser.CreateDeserialiser();
            _serialiser = RequestSeserialiser.CreateSerialiser();
            try
            {
                _isams = _dataService.MethodRequestAsync(Method, ApiKey, _deserialiser, _serialiser).Result;
            }
            catch (Exception e) {

                WriteWarning(e.Message);
            }
            
            if (_isams is null)
            {
                WriteWarning("Error returning result from API, root is null");
            }

            base.BeginProcessing();
        }
    }
}

