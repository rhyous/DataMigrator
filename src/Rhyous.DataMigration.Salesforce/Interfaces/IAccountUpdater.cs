namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface IAccountUpdater
    {
        Task<Account> UpdateAsync(Account account, string instanceUrl, string accessToken);
        Task<Account> UpdateIfChangesAsync(Account existing, Account withChanges, string instanceUrl, string accessToken);
    }
}