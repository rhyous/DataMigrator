namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface IAccountDetector
    {
        Task<Account?> DetectAsync(Account account, string instanceUrl, string accessToken);
    }
}