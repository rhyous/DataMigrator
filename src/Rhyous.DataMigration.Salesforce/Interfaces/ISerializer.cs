﻿namespace Rhyous.DataMigration.Salesforce.Interfaces
{
    public interface ISerializer
    {
        string Serialize(object obj);
        T? Deserialize<T>(string json) where T : class, new();
    }
}
