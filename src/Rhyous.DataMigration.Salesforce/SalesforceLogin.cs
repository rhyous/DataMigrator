using Rhyous.DataMigration.Salesforce.Interfaces;

namespace Rhyous.DataMigration.Salesforce
{
    public class SalesforceLogin : ISalesforceLogin
    {
        private readonly ISalesforceConfig _SalesforceConfig;
        private readonly ISerializer _Serializer;
        private readonly IHttpClientFactory _HttpClientFactory;

        public SalesforceLogin(ISalesforceConfig salesforceConfig,
                               ISerializer serializer,
                               IHttpClientFactory httpClientFactory)
        {
            _SalesforceConfig = salesforceConfig;
            _Serializer = serializer;
            _HttpClientFactory = httpClientFactory;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            var client = _HttpClientFactory.GetHttpClient(_SalesforceConfig.TokenRequestUrl);
            var content = new FormUrlEncodedContent([
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("client_id", _SalesforceConfig.ClientId),
                    new KeyValuePair<string, string>("client_secret", _SalesforceConfig.ClientSecret),
                    new KeyValuePair<string, string>("username", _SalesforceConfig.Username),
                    new KeyValuePair<string, string>("password", _SalesforceConfig.Password)
                ]);

            var response = await client.PostAsync(_SalesforceConfig.TokenRequestUrl, content);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var authenticationResponse = _Serializer.Deserialize<AuthenticationResponse>(responseString);

            return authenticationResponse?.AccessToken ?? throw new Exception("Salesforce JWT Token failed to deserialize.");
        }
    }
}
