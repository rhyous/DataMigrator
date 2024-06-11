namespace Rhyous.DataMigration.Salesforce
{
    [AttributeUsage(AttributeTargets.Property)]
    public class JsonPropertyAttribute : Attribute
    {
        public JsonPropertyAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
