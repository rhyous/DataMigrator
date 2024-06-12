using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.StringLibrary;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace Rhyous.DataMigration
{
    internal class SingleAccountMigrator : ISingleAccountMigrator
    {
        private readonly IHttpClientFactory _HttpClientFactory;
        private readonly ISerializer _Serializer;
        private readonly ISalesforceRecordTypeProvider _SalesforceRecordTypeProvider;

        public SingleAccountMigrator(IHttpClientFactory httpClientFactory,
                                     ISerializer serializer,
                                     ISalesforceRecordTypeProvider salesforceRecordTypeProvider)
        {
            _HttpClientFactory = httpClientFactory;
            _Serializer = serializer;
            _SalesforceRecordTypeProvider = salesforceRecordTypeProvider;
        }
        public async Task MigrateAsync(string account, string jwtToken, string instanceUrl)
        {
            var client = _HttpClientFactory.GetHttpClient(instanceUrl);
            var recordTypesJson = await _SalesforceRecordTypeProvider.GetRecordTypeIdsAsync(jwtToken, instanceUrl);
            var recordTypeId = "abcdefghijgklmnop"; // Business
            var accountData = new
            {
                Name = "Test Account #1",
                Phone = "1234567890",
                Website = "http://example.com",
                RecordTypeId = recordTypeId
            };
            var json = _Serializer.Serialize(accountData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var postUrl = StringConcat.WithSeparator('/', instanceUrl, "/services/data/v54.0/sobjects/Account");
            var request = new HttpRequestMessage(HttpMethod.Post, postUrl);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);
            request.Content = content;
            var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            var message = response.Content.ReadAsStringAsync();

            // Get account from AA SQL database

            // Post account to Salesforce

            // Get each additional entity from AA SQL database

            // Post each additional entity to Salesforce
        }
    }
}
