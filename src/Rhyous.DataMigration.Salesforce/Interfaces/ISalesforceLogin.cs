
namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface ISalesforceLogin
    {
        Task<AuthenticationResponse> GetAccessTokenAsync();
    }
}