using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.StringLibrary;
using System.Text;

namespace Rhyous.DataMigration.Salesforce
{
    public class AccountCreator : IAccountCreator
    {
        private readonly ISerializer _Serializer;
        private readonly IHttpClientFactory _HttpClientFactory;

        public AccountCreator(ISerializer serializer,
                              IHttpClientFactory httpClientFactory)
        {
            _Serializer = serializer;
            _HttpClientFactory = httpClientFactory;
        }

        public async Task<Account> CreateAsync(Account account, string instanceUrl, string accessToken)
        {
            // Post account to Salesforce
            var client = _HttpClientFactory.GetHttpClient(instanceUrl);
            var json = _Serializer.Serialize(account);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var postUrl = StringConcat.WithSeparator('/', instanceUrl, "/services/data/v54.0/sobjects/Account");
            var request = new HttpRequestMessage(HttpMethod.Post, postUrl);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            request.Content = content;
            var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            var message = response.Content.ReadAsStringAsync();
            // Update account from response
            return account;
        }
    }
}
