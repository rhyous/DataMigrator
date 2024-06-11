using Rhyous.DataMigration.Interfaces;
using Rhyous.StringLibrary;

namespace Rhyous.DataMigration
{
    internal class BatchConfiguration : IBatchConfiguration
    {
        public const int DefaultBatchSize = 5;

        public BatchConfiguration(IArgs args)
        {
            BatchSize = args.Value("BatchSize").To<int>(DefaultBatchSize);
        }
        public int BatchSize { get; }
    }
}
