namespace Rhyous.DataMigration.Interfaces
{
    internal interface IBatchAccountMigrator
    {
        Task MigrateAsync(Queue<string> accounts, string jwtToken, string instanceUrl);
    }
}