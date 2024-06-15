using Autofac;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Rhyous.DataMigration.AdvisorsAssistant.Interfaces;
using Rhyous.DataMigration.AdvisorsAssistant.Models;
using Rhyous.DataMigration.Factories;
using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Logging;
using Rhyous.DataMigration.Models;
using Rhyous.DataMigration.Salesforce;
using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.DataMigration.Serializers;

namespace Rhyous.DataMigration.DependencyInjection
{
    internal class DataMigrationModule : Module
    {
        /// <summary>An override of the Load method, which does the actual registration.</summary>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArgsWrapper>().As<IArgs>().SingleInstance();
            builder.RegisterType<FileWrapper>().As<IFileIO>().SingleInstance();
            builder.RegisterType<ConsoleLogger>().As<DataMigration.Interfaces.ILogger>().SingleInstance();
            builder.RegisterType<ConsoleSFLogger>().As<Salesforce.Interfaces.ILogger>().SingleInstance();

            builder.RegisterType<CustomJsonPropertyAttributeResolver>().As<ICustomJsonPropertyAttributeResolver>().SingleInstance();
            builder.RegisterType<CustomJsonSerializerSettings>().As<JsonSerializerSettings>().SingleInstance();
            builder.RegisterType<NewtonsoftSerializer>().As<ISerializer>().SingleInstance();

            builder.Register(ctx =>
            {
                var args = ctx.Resolve<IArgs>();
                var optionsBuilder = new DbContextOptionsBuilder<AdvisorsAssistantContext>();
                optionsBuilder.UseSqlServer(args.Value("AAConnectionString"));
                return new AdvisorsAssistantContext(optionsBuilder.Options);
            }).As<IAdvisorsAssistantContext>();
            builder.RegisterType<AdvisorsAssistantContextFactory>().As<IAdvisorsAssistantContextFactory>().SingleInstance();
            builder.RegisterType<AADataExtractor>().As<IDataExtractor<ExtractedData>>().SingleInstance();

            builder.RegisterType<HttpClientFactory>().As<IHttpClientFactory>().SingleInstance();
            builder.RegisterType<SalesforceConfigFromArgs>().As<ISalesforceConfig>().SingleInstance();
            builder.RegisterType<SalesforceLogin>().As<ISalesforceLogin>().SingleInstance();
            builder.RegisterType<SalesforceRecordTypeProvider>().As<ISalesforceRecordTypeProvider>().SingleInstance();
            builder.RegisterType<AccountCreator>().As<IAccountCreator>().SingleInstance();
            builder.RegisterType<AccountDetector>().As<IAccountDetector>().SingleInstance();
            builder.RegisterType<AccountUpdater>().As<IAccountUpdater>().SingleInstance();

            builder.RegisterType<BatchConfiguration>().As<IBatchConfiguration>().SingleInstance();
            builder.RegisterType<SingleAccountMigrator>().As<ISingleAccountMigrator>().SingleInstance();
            builder.RegisterType<BatchAccountMigrator>().As<IBatchAccountMigrator>().SingleInstance();
            builder.RegisterType<Starter>().As<IStarter>().SingleInstance();
        }
    }
}
