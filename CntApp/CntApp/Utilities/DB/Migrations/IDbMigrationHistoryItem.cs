using System;

namespace CntApp.Utilities.DB.Migrations
{
    public interface IDbMigrationHistoryItem
    {
        DateTimeOffset TimeCreated { get; }
        string Description { get; }
    }
}