using Rhyous.DataMigration.AdvisorsAssistant.Models;
using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Models;
using Rhyous.DataMigration.Salesforce;
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
        private readonly IDataExtractor<ExtractedData> _DataExtractor;
        private readonly IAccountCreator _AccountCreator;
        private readonly IAccountDetector _AccountDetector;
        private readonly IAccountUpdater _AccountUpdater;

        public SingleAccountMigrator(IHttpClientFactory httpClientFactory,
                                     ISerializer serializer,
                                     ISalesforceRecordTypeProvider salesforceRecordTypeProvider,
                                     IDataExtractor<ExtractedData> dataExtractor,
                                     IAccountCreator accountCreator,
                                     IAccountDetector accountDetector,
                                     IAccountUpdater accountUpdater)
        {
            _HttpClientFactory = httpClientFactory;
            _Serializer = serializer;
            _SalesforceRecordTypeProvider = salesforceRecordTypeProvider;
            _DataExtractor = dataExtractor;
            _AccountCreator = accountCreator;
            _AccountDetector = accountDetector;
            _AccountUpdater = accountUpdater;
        }
        public async Task MigrateAsync(string accountId, string jwtToken, string instanceUrl)
        {
            var client = _HttpClientFactory.GetHttpClient(instanceUrl);

            // Get account from AA SQL database
            var extractedData = _DataExtractor.Extract(accountId);

            // Post account to Salesforce
            var sfAccount = await _AccountDetector.DetectAsync(extractedData.Account, instanceUrl, jwtToken);
            if (sfAccount == null)
                sfAccount = await _AccountCreator.CreateAsync(extractedData.Account, instanceUrl, jwtToken);
            else
                sfAccount = await _AccountUpdater.UpdateIfChangesAsync(sfAccount, extractedData.Account, instanceUrl, jwtToken);

            // Get each additional entity from AA SQL database

            // Post each additional entity to Salesforce
        }


    }
}
