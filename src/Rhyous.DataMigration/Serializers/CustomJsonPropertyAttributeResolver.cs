using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace Rhyous.DataMigration.Serializers;

public class CustomJsonPropertyAttributeResolver : DefaultContractResolver, ICustomJsonPropertyAttributeResolver
{
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        var property = base.CreateProperty(member, memberSerialization);

        // Check if the custom JsonPropertyNameAttribute is defined on this property
        var attr = member.GetCustomAttribute<Salesforce.JsonPropertyAttribute>();
        if (attr != null)
        {
            // Set the property name from the attribute
            property.PropertyName = attr.Name;
        }

        return property;
    }
}