using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Salesforce.Interfaces;

namespace Rhyous.DataMigration
{
    internal class SalesforceConfigFromArgs : ISalesforceConfig
    {
        private readonly IArgs _Args;

        public SalesforceConfigFromArgs(IArgs args)
        {
            _Args = args;
        }

        public string TokenRequestUrl => _Args.Value(nameof(TokenRequestUrl));
        public string ClientId => _Args.Value(nameof(ClientId));
        public string ClientSecret => _Args.Value(nameof(ClientSecret));
        public string Username => _Args.Value(nameof(Username));
        public string Password => _Args.Value(nameof(Password));
    }
}
