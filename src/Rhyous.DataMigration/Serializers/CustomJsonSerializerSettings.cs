using Newtonsoft.Json;

namespace Rhyous.DataMigration.Serializers
{
    class CustomJsonSerializerSettings : JsonSerializerSettings
    {
        public CustomJsonSerializerSettings(ICustomJsonPropertyAttributeResolver customJsonContractResolver)
        {
            ContractResolver = customJsonContractResolver;
        }
    }
}
