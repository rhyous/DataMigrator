namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface ISalesforceRecordTypeProvider
    {
        Task<string> GetRecordTypeIdsAsync(string accessToken, string instanceUrl);
    }
}