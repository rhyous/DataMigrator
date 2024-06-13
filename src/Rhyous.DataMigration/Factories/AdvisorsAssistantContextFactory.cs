using Autofac;
using Rhyous.DataMigration.AdvisorsAssistant.Interfaces;
using Rhyous.DataMigration.AdvisorsAssistant.Models;

namespace Rhyous.DataMigration.Factories
{
    internal class AdvisorsAssistantContextFactory : IAdvisorsAssistantContextFactory
    {
        private readonly ILifetimeScope _Scope;

        public AdvisorsAssistantContextFactory(ILifetimeScope scope)
        {
            _Scope = scope;
        }
        public IAdvisorsAssistantContext Create()
        {
            return _Scope.Resolve<IAdvisorsAssistantContext>();
        }
    }
}
