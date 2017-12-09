using System;
using System.Threading.Tasks;
using SQLite;

namespace CntApp.Utilities.DB.Migrations
{
    public class _20171209_Created : DbMigrationBase
    {
        public override DateTimeOffset TimeCreated => DateTimeOffset.Parse("2017-12-09");

        public override string Description => nameof(_20171209_Created);

        public override async Task Apply(SQLiteAsyncConnection dbConnection)
        {
        }
    }
}