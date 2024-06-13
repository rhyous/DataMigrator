using Rhyous.DataMigration.AdvisorsAssistant.Models;

namespace Rhyous.DataMigration.AdvisorsAssistant.Interfaces
{
    public interface IAdvisorsAssistantContextFactory
    {
        IAdvisorsAssistantContext Create();
        
    }
}
