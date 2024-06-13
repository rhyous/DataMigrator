using Rhyous.DataMigration.Salesforce;

namespace Rhyous.DataMigration.Models
{
    internal class ExtractedData
    {
        public static ExtractedData Empty = new ExtractedData();
        public Account Account { get; set; }
    }
}
