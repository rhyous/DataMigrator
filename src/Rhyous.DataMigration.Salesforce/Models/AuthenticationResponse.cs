namespace Rhyous.DataMigration.Salesforce
{
    internal class AuthenticationResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
