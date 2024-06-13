using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.DataMigration.Salesforce.Models;

namespace Rhyous.DataMigration.Salesforce
{
    public class AccountDetector : IAccountDetector
    {
        private readonly ISerializer _Serializer;
        private readonly IHttpClientFactory _HttpClientFactory;

        public AccountDetector(ISerializer serializer,
                               IHttpClientFactory httpClientFactory)
        {
            _Serializer = serializer;
            _HttpClientFactory = httpClientFactory;
        }
        public async Task<Account?> DetectAsync(Account account, string instanceUrl, string accessToken)
        {
            // Post account to Salesforce
            var client = _HttpClientFactory.GetHttpClient(instanceUrl);
            var query = $"SELECT"
                      + $" Id, Name, Phone, WebSite " // Add whatever fields we want here
                      + $"FROM Account WHERE Name = '{account.Name.Trim()}'"; // We may want to use the Id
            var requestUrl = $"{instanceUrl}/services/data/v54.0/query?q={Uri.EscapeDataString(query)}";

            var detectRequest = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            detectRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            var detectResponse = await client.SendAsync(detectRequest);

            detectResponse.EnsureSuccessStatusCode();
            var detectJson = await detectResponse.Content.ReadAsStringAsync();

            var queryResponse = _Serializer.Deserialize<QueryResponse<Account>>(detectJson);
            if (queryResponse != null && queryResponse.Records !=null && queryResponse.Records.Count == 1)
            {
                var existingAccount = queryResponse.Records[0];
                return existingAccount; 
            }
            // Update account from response
            return null;
        }
    }
}
