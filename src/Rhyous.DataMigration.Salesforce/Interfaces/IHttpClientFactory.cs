namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface IHttpClientFactory
    {
        IHttpClient GetHttpClient(string? url = null);
    }
}