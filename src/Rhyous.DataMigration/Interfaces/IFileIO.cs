namespace Rhyous.DataMigration.Interfaces
{
    public interface IFileIO
    {
        string[] ReadAllLines(string path);
    }
}
