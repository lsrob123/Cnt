using System;
using System.Threading.Tasks;
using SQLite;

namespace CntApp.Utilities.DB.Migrations
{
    public abstract class DbMigrationBase : IDbMigrationHistoryItem
    {
        public abstract DateTimeOffset TimeCreated { get; }
        public abstract string Description { get; }
        public abstract Task Apply(SQLiteAsyncConnection dbConnection);
    }
}