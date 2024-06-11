using Autofac;
using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.SimpleArgs;

namespace Rhyous.DataMigration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            new ArgsManager<ArgsHandler>().Start(args);
            var builder = new ContainerBuilder();

            var container = builder.Build();
            var starter = container.Resolve<IStarter>();
            await starter.StartAsync();
        }
    }

    internal class Starter : IStarter
    {
        private readonly ISalesforceLogin _SalesforceLogin;
        private readonly IArgs _Args;

        public Starter(ISalesforceLogin salesforceLogin,
                       IArgs args)
        {
            _SalesforceLogin = salesforceLogin;
            _Args = args;
        }
        public async Task StartAsync()
        {
            var jwtToken = _SalesforceLogin.GetAccessTokenAsync();

            if (!string.IsNullOrWhiteSpace(_Args.Value("Account")))
            {
            }
            if (!string.IsNullOrWhiteSpace(_Args.Value("Batch")))
            {
            }
        }
    }
}