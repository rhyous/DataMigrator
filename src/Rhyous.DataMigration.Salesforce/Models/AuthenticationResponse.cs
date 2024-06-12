namespace Rhyous.DataMigration.Salesforce
{
    public class AuthenticationResponse
    {
        [JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        [JsonProperty("instance_url")]
        public string? InstanceUrl { get; set; }
    }
}
