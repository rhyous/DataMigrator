using Rhyous.DataMigration.Interfaces;

namespace Rhyous.DataMigration
{
    internal class FileWrapper : IFileIO
    {
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
