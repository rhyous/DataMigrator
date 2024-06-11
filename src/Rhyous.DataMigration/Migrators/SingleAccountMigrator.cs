using Rhyous.DataMigration.Interfaces;

namespace Rhyous.DataMigration
{
    internal class SingleAccountMigrator : ISingleAccountMigrator
    {
        public async Task MigrateAsync(string account, string jwtToken)
        {
            // Get account from AA SQL database

            // Post account to Salesforce

            // Get each additional entity from AA SQL database

            // Post each additional entity to Salesforce
        }
    }
}
