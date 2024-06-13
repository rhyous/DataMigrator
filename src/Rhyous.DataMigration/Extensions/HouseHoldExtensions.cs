using Rhyous.DataMigration.AdvisorsAssistant.Models;
using Rhyous.DataMigration.Salesforce;

namespace Rhyous.DataMigration
{
    internal static class HouseHoldExtensions
    {
        public static Account ToAccount(this AahouseHold hh)
        {
            return new Account 
            {
                Name = hh.CDescription
                
            };
        }
    }
}
