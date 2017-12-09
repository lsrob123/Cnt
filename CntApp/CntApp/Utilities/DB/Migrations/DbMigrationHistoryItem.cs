using System;
using SQLite;

namespace CntApp.Utilities.DB.Migrations
{
    [Table("MigrationHistory")]
    public class DbMigrationHistoryItem : IDbMigrationHistoryItem
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("_id")]
        public long Id { get; set; }

        public DateTimeOffset TimeCreated { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}