namespace Rhyous.DataMigration.Interfaces
{
    internal interface ISingleAccountMigrator
    {
        Task MigrateAsync(string account, string jwtToken, string instanceUrl);
    }
}