using Rhyous.DataMigration.Interfaces;

namespace Rhyous.DataMigration
{
    internal class BatchAccountMigrator : IBatchAccountMigrator
    {
        private readonly ISingleAccountMigrator _SingleAccountMigrator;
        private readonly IBatchConfiguration _BatchConfiguration;

        public BatchAccountMigrator(ISingleAccountMigrator singleAccountMigrator,
                                    IBatchConfiguration batchConfiguration)
        {
            _SingleAccountMigrator = singleAccountMigrator;
            _BatchConfiguration = batchConfiguration;
        }
        public async Task MigrateAsync(Queue<string> accounts, string jwtToken, string instanceUrl)
        {
            var tasks = new List<Task>();
            using (var semaphore = new SemaphoreSlim(_BatchConfiguration.BatchSize))
            {
                while (accounts.Count > 0)
                {
                    await semaphore.WaitAsync();

                    var account = accounts.Dequeue();
                    tasks.Add(Task.Run(async () =>
                    {
                        try
                        {
                            await _SingleAccountMigrator.MigrateAsync(account, jwtToken, instanceUrl);
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }));
                }

                await Task.WhenAll(tasks);
            }
        }
    }
}
