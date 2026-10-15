using IsamsBatchApiClient.Services;

namespace IsamsBatchApiClient.PWSH { 
    public class ModuleState {
            public ConnectionModel ConnectionModel { get; }

            public OAuthHttpServices OAuthHttpServices { get; }

            public ModuleState(
                ConnectionModel connectionModel,
                OAuthHttpServices oAuthDataService = null
            )
            {
                ConnectionModel = connectionModel;
                OAuthHttpServices = oAuthDataService;

            }
    }
}