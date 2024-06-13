using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Salesforce.Interfaces;

namespace Rhyous.DataMigration
{
    internal class Starter : IStarter
    {
        private readonly ISalesforceLogin _SalesforceLogin;
        private readonly IArgs _Args;
        private readonly IFileIO _FileIO;
        private readonly ISingleAccountMigrator _SingleAccountMigrator;
        private readonly IBatchAccountMigrator _BatchAccountMigrator;

        public Starter(ISalesforceLogin salesforceLogin,
                       IArgs args,
                       IFileIO fileIO,
                       ISingleAccountMigrator singleAccountMigrator,
                       IBatchAccountMigrator batchAccountMigrator)
        {
            _SalesforceLogin = salesforceLogin;
            _Args = args;
            _FileIO = fileIO;
            _SingleAccountMigrator = singleAccountMigrator;
            _BatchAccountMigrator = batchAccountMigrator;
        }
        public async Task StartAsync()
        {
            var authenticationResponse = await _SalesforceLogin.GetAccessTokenAsync();

            // Single Account
            var singleAccount = _Args.Value("Account");
            if (!string.IsNullOrWhiteSpace(singleAccount))
            {
                await _SingleAccountMigrator.MigrateAsync(singleAccount, authenticationResponse.AccessToken, authenticationResponse.InstanceUrl);
                return;
            }

            // Batched Accounts
            var file = _Args.Value("AccountsFile");
            if (string.IsNullOrWhiteSpace(file))
                return;
            var accounts = new Queue<string>(_FileIO.ReadAllLines(file));
            if (!string.IsNullOrWhiteSpace(_Args.Value("Batch")))
            {
                await _BatchAccountMigrator.MigrateAsync(accounts, authenticationResponse.AccessToken, authenticationResponse.InstanceUrl);
            }
        }
    }
}