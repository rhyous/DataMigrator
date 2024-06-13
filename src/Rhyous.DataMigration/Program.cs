using Autofac;
using Rhyous.DataMigration.DependencyInjection;
using Rhyous.DataMigration.Interfaces;
using Rhyous.SimpleArgs;

namespace Rhyous.DataMigration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            new ArgsManager<ArgsHandler>().Start(args);
            var builder = new ContainerBuilder();
            builder.RegisterModule<DataMigrationModule>();
            var container = builder.Build();
            var starter = container.Resolve<IStarter>();
            await starter.StartAsync();
        }
    }
}