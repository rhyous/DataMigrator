using Rhyous.DataMigration.Salesforce.Interfaces;
using System.Net.Http.Headers;

namespace Rhyous.DataMigration.Salesforce
{
    public class SalesforceRecordTypeProvider : ISalesforceRecordTypeProvider
    {
        public async Task<string> GetRecordTypeIdsAsync(string accessToken, string instanceUrl)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var request = new HttpRequestMessage(HttpMethod.Get, instanceUrl + "/services/data/v54.0/sobjects/Account/describe");

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
        }
    }
}
