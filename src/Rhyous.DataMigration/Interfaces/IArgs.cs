using Rhyous.SimpleArgs;

namespace Rhyous.DataMigration.Interfaces
{
    internal interface IArgs
    {
        Argument Get(string name);
        string Value(string name);
    }
}