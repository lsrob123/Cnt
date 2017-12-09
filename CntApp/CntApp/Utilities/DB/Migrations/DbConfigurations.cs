using System;
using System.Collections.Generic;
using CntApp.Utilities.Files;
using CntApp.Utilities.Infrastructure;
using SQLite;

namespace CntApp.Utilities.DB.Migrations
{
    public class DbConfigurations
    {
        private static readonly ICollection<DbMigrationBase> Migrations = new List<DbMigrationBase>();

        public DbConfigurations(IFileManager fileManager)
        {
            var fileManager1 = fileManager;
            var dbFilePath = fileManager1.GetSqliteDbFilePath(nameof(LocalDb));

            DbConnection = new SQLiteAsyncConnection(dbFilePath);

            if (fileManager1.FileExists(dbFilePath))
                Create();
        }

        public SQLiteAsyncConnection DbConnection { get; }

        public ProcessResult Create()
        {
            try
            {
                return ProcessResultType.Ok;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public ProcessResult Configure()
        {
            try
            {
                return ProcessResultType.Ok;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}