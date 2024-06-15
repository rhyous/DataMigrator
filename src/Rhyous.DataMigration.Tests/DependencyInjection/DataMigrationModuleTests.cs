using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using Rhyous.DataMigration.AdvisorsAssistant.Interfaces;
using Rhyous.DataMigration.AdvisorsAssistant.Models;
using Rhyous.DataMigration.DependencyInjection;
using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Models;
using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.DataMigration.Serializers;
using Rhyous.SimpleArgs;

namespace Rhyous.DataMigration.Tests.DependencyInjection
{
    [TestClass]
    public class DataMigrationModuleTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private MockRepository _MockRepository;

        private Autofac.IContainer _Container;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        [ClassInitialize]
        public static void ClassInitialize(TestContext context) 
        {
            new ArgsManager<ArgsHandler>();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _MockRepository = new MockRepository(MockBehavior.Strict);

            var builder = new ContainerBuilder();

            // Register items in upstream scopes
            // The assumption is made that if you add a mock here, it is already registered in upstream scope.
            

            // Register Module
            builder.RegisterModule<DataMigrationModule>();

            _Container = builder.Build();
        }

        [TestMethod]
        public void DataMigrationModuleTests_IArgs_Registered_Singleton()
        {
            var a = _Container.Resolve<IArgs>();
            var b = _Container.Resolve<IArgs>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IFileIO_Registered_Singleton()
        {
            var a = _Container.Resolve<IFileIO>();
            var b = _Container.Resolve<IFileIO>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_DataMigration_Interfaces_ILogger_Registered_Singleton()
        {
            var a = _Container.Resolve<DataMigration.Interfaces.ILogger>();
            var b = _Container.Resolve<DataMigration.Interfaces.ILogger>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_Salesforce_Interfaces_ILogger_Registered_Singleton()
        {
            var a = _Container.Resolve<Salesforce.Interfaces.ILogger>();
            var b = _Container.Resolve<Salesforce.Interfaces.ILogger>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_ICustomJsonPropertyAttributeResolver_Registered_Singleton()
        {
            var a = _Container.Resolve<ICustomJsonPropertyAttributeResolver>();
            var b = _Container.Resolve<ICustomJsonPropertyAttributeResolver>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_JsonSerializerSettings_Registered_Singleton()
        {
            var a = _Container.Resolve<JsonSerializerSettings>();
            var b = _Container.Resolve<JsonSerializerSettings>();
            Assert.IsNotNull(a);
            Assert.IsTrue(a is CustomJsonSerializerSettings);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_ISerializer_Registered_Singleton()
        {
            var a = _Container.Resolve<ISerializer>();
            var b = _Container.Resolve<ISerializer>();
            Assert.IsNotNull(a);
            Assert.IsTrue(a is NewtonsoftSerializer);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IAdvisorsAssistantContext_Registered_Transient()
        {
            var a = _Container.Resolve<IAdvisorsAssistantContext>();
            var b = _Container.Resolve<IAdvisorsAssistantContext>();
            Assert.IsNotNull(a);
            Assert.AreNotSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IAdvisorsAssistantContextFactory_Registered_Singleton()
        {
            var a = _Container.Resolve<IAdvisorsAssistantContextFactory>();
            var b = _Container.Resolve<IAdvisorsAssistantContextFactory>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IDataExtractor_ExtractedData_Registered_Singleton()
        {
            var a = _Container.Resolve<IDataExtractor<ExtractedData>>();
            var b = _Container.Resolve<IDataExtractor<ExtractedData>>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IHttpClientFactory_Registered_Singleton()
        {
            var a = _Container.Resolve<IHttpClientFactory>();
            var b = _Container.Resolve<IHttpClientFactory>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_ISalesforceConfig_Registered_Singleton()
        {
            var a = _Container.Resolve<ISalesforceConfig>();
            var b = _Container.Resolve<ISalesforceConfig>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_ISalesforceLogin_Registered_Singleton()
        {
            var a = _Container.Resolve<ISalesforceLogin>();
            var b = _Container.Resolve<ISalesforceLogin>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_ISalesforceRecordTypeProvider_Registered_Singleton()
        {
            var a = _Container.Resolve<ISalesforceRecordTypeProvider>();
            var b = _Container.Resolve<ISalesforceRecordTypeProvider>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IAccountCreator_Registered_Singleton()
        {
            var a = _Container.Resolve<IAccountCreator>();
            var b = _Container.Resolve<IAccountCreator>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IAccountDetector_Registered_Singleton()
        {
            var a = _Container.Resolve<IAccountDetector>();
            var b = _Container.Resolve<IAccountDetector>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IAccountUpdater_Registered_Singleton()
        {
            var a = _Container.Resolve<IAccountUpdater>();
            var b = _Container.Resolve<IAccountUpdater>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IBatchConfiguration_Registered_Singleton()
        {
            var a = _Container.Resolve<IBatchConfiguration>();
            var b = _Container.Resolve<IBatchConfiguration>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_ISingleAccountMigrator_Registered_Singleton()
        {
            var a = _Container.Resolve<ISingleAccountMigrator>();
            var b = _Container.Resolve<ISingleAccountMigrator>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IBatchAccountMigrator_Registered_Singleton()
        {
            var a = _Container.Resolve<IBatchAccountMigrator>();
            var b = _Container.Resolve<IBatchAccountMigrator>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void DataMigrationModuleTests_IStarter_Registered_Singleton()
        {
            var a = _Container.Resolve<IStarter>();
            var b = _Container.Resolve<IStarter>();
            Assert.IsNotNull(a);
            Assert.AreSame(a, b);
        }
    }
}
