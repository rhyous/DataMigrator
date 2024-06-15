namespace Rhyous.DataMigration.Logging
{
    internal class ConsoleSFLogger : Salesforce.Interfaces.ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
