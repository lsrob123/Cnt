using CntApp.Utilities.Files;
using SQLite;
using System.IO;
using CntApp.Utilities.DB.Migrations;

namespace CntApp.Utilities.DB
{
    public class LocalDb : ILocalDb
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public LocalDb(DbConfigurations configurations)
        {
            _dbConnection = configurations.DbConnection;
        }
    }
}