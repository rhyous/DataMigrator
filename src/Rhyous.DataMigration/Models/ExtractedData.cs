using Rhyous.DataMigration.Salesforce;

namespace Rhyous.DataMigration.Models
{
    internal class ExtractedData
    {
        public static ExtractedData Empty = new ExtractedData();

        /// <summary>An Account in Salesforce is equivalent to a Household in AA.</summary>
        public Account? Account { get; set; }

        public List<Note>? Notes { get; set; }
    }

}
