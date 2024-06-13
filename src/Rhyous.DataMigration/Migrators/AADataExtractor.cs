using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Rhyous.DataMigration.AdvisorsAssistant.Interfaces;
using Rhyous.DataMigration.AdvisorsAssistant.Models;
using Rhyous.DataMigration.Interfaces;
using Rhyous.DataMigration.Models;
using Rhyous.StringLibrary;

namespace Rhyous.DataMigration
{
    internal class AADataExtractor : IDataExtractor<ExtractedData>
    {
        private readonly IAdvisorsAssistantContextFactory _AdvisorsAssistantContextFactory;
        private readonly ILogger _Logger;

        public AADataExtractor(IAdvisorsAssistantContextFactory advisorsAssistantContextFactory,
                               ILogger logger)
        {
            _AdvisorsAssistantContextFactory = advisorsAssistantContextFactory;
            _Logger = logger;
        }

        public ExtractedData Extract(string strId)
        {
            var id = strId.To<int>();
            var extractedData = new ExtractedData();
            using (var context = _AdvisorsAssistantContextFactory.Create())
            {
                // This is were we get the data from AdvisorsAssistant
                var household = context.HouseHolds
                                       .Include(h=>h.AahouseHoldMembers)
                                       .FirstOrDefault(h => h.IKeyId == id);
                if (household == null)
                {
                    _Logger.Log($"Account {strId} was not found in the source system.");
                    return ExtractedData.Empty;
                }
                extractedData.Account = household.ToAccount();
                var phone = context.Phones.FirstOrDefault(p => p.Ikeyclient == household.IKeyClient);
                extractedData.Account.Phone = phone?.Cphonenum;
            }
            return extractedData;
        }
    }
}
