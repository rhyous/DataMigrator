using Autofac;
using Newtonsoft.Json;
using Rhyous.DataMigration.Interfaces;
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

            builder.RegisterType<CustomJsonPropertyAttributeResolver>().As<ICustomJsonPropertyAttributeResolver>().SingleInstance();
            builder.RegisterType<CustomJsonSerializerSettings>().As<JsonSerializerSettings>().SingleInstance();
            builder.RegisterType<NewtonsoftSerializer>().As<ISerializer>().SingleInstance();

            builder.RegisterType<HttpClientFactory>().As<IHttpClientFactory>().SingleInstance();
            builder.RegisterType<SalesforceConfigFromArgs>().As<ISalesforceConfig>().SingleInstance();
            builder.RegisterType<SalesforceLogin>().As<ISalesforceLogin>().SingleInstance();

            builder.RegisterType<BatchConfiguration>().As<IBatchConfiguration>().SingleInstance();
            builder.RegisterType<SingleAccountMigrator>().As<ISingleAccountMigrator>().SingleInstance();
            builder.RegisterType<BatchAccountMigrator>().As<IBatchAccountMigrator>().SingleInstance();
            builder.RegisterType<Starter>().As<IStarter>().SingleInstance();
        }
    }
}
