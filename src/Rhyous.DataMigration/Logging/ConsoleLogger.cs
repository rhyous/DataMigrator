using Rhyous.DataMigration.Interfaces;

namespace Rhyous.DataMigration.Logging
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
