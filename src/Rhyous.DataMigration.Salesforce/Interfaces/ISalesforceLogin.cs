
namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface ISalesforceLogin
    {
        Task<string> GetAccessTokenAsync();
    }
}