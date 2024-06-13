using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.StringLibrary;
using System.Reflection;
using System.Text;

namespace Rhyous.DataMigration.Salesforce
{
    public class AccountUpdater : IAccountUpdater
    {
        private readonly ISerializer _Serializer;
        private readonly IHttpClientFactory _HttpClientFactory;

        public AccountUpdater(ISerializer serializer,
                              IHttpClientFactory httpClientFactory)
        {
            _Serializer = serializer;
            _HttpClientFactory = httpClientFactory;
        }

        public async Task<Account> UpdateAsync(Account account, string instanceUrl, string accessToken)
        {
            // Post account to Salesforce
            var client = _HttpClientFactory.GetHttpClient(instanceUrl);
            var json = _Serializer.Serialize(account);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var patchUrl = StringConcat.WithSeparator('/', instanceUrl, $"/services/data/v54.0/sobjects/Account", account.Id);
            var request = new HttpRequestMessage(HttpMethod.Patch, patchUrl);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            request.Content = content;
            var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            var message = response.Content.ReadAsStringAsync();
            // Update account from response
            return account;
        }

        public async Task<Account> UpdateIfChangesAsync(Account existing, Account withChanges, string instanceUrl, string accessToken)
        {
            var changeFound = false;
            foreach (var prop in typeof(Account).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var existingValue = prop.GetValue(existing);
                var newValue = prop.GetValue(withChanges);
                if (newValue != null && !newValue.Equals(existingValue))
                {
                    prop.SetValue(existing, newValue);
                    changeFound = true;
                }
            }
            if (changeFound)
            {
                await UpdateAsync(existing, instanceUrl, accessToken);
            }
            return existing;
        }
    }
}
