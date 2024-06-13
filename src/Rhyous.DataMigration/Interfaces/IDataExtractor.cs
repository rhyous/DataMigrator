namespace Rhyous.DataMigration.Interfaces
{
    internal interface IDataExtractor<T>
    {
        T Extract(string id);
    }
}
