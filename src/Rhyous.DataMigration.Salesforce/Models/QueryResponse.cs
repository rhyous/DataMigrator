namespace Rhyous.DataMigration.Salesforce.Models
{
    /// <summary>A model for handling Salesforce query responses.</summary>
    /// <typeparam name="T">The type of records.</typeparam>
    /// <remarks>
    /// None: {"totalSize":0,"done":true,"records":[]}
    /// One:  {"totalSize":1,"done":true,"records":[{"attributes":{"type":"Account","url":"/services/data/v54.0/sobjects/Account/001E100000RzQe5IAF"},"Id":"001E100000RzQe5IAF"}]}
    /// </remarks>
    public class QueryResponse<T>
    {
        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }

        [JsonProperty("records")]
        public List<T>? Records { get; set; }
    }
}
