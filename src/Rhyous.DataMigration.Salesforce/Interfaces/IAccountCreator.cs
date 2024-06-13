namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface IAccountCreator
    {
        Task<Account> CreateAsync(Account account, string instanceUrl, string accessToken);
    }
}