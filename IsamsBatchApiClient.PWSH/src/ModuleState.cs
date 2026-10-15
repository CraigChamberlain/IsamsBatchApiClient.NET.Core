using IsamsBatchApiClient.Services;

namespace IsamsBatchApiClient.PWSH { 
    public class ModuleState {
            public ConnectionModel ConnectionModel { get; }
            public string DefaultApiKey { get; }

            public ApiKeyHttpServices ApiKeyDataServices { get; }
            public OAuthHttpServices OAuthHttpServices { get; }

            public ModuleState(
                ConnectionModel connectionModel,
                string defaultApiKey,
                ApiKeyHttpServices apiKeyDataService = null,
                OAuthHttpServices oAuthDataService = null
            )
            {
                ConnectionModel = connectionModel;
                DefaultApiKey = defaultApiKey;
                ApiKeyDataServices = apiKeyDataService;
                OAuthHttpServices = oAuthDataService;

            }
    }
}