namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface ISalesforceConfig
    {
        public string TokenRequestUrl { get; }
        public string ClientId { get; }
        public string ClientSecret { get; }
        public string Username { get; }
        public string Password { get; }
    }
}
