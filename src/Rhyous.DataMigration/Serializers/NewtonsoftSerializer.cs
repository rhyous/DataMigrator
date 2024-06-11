using Newtonsoft.Json;
using Rhyous.DataMigration.Salesforce.Interfaces;

namespace Rhyous.DataMigration.Serializers
{
    class NewtonsoftSerializer : ISerializer
    {
        private readonly JsonSerializerSettings _Settings;

        public NewtonsoftSerializer(JsonSerializerSettings settings)
        {
            _Settings = settings;
        }

        public T? Deserialize<T>(string json) where T : class, new()
        {
            return JsonConvert.DeserializeObject<T>(json, _Settings);
        }

        public string Serialize(object o)
        {
            return JsonConvert.SerializeObject(o, _Settings);
        }
    }
}
