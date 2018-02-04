using System.Linq;
using CntApp.Domains.Contacts;
using CntApp.Utilities.Files;
using Lx.Utilities.Contracts.Mapping;
using Lx.Utilities.NetStandard.Pagination;
using SQLite;

namespace CntApp.Utilities.Persistence
{
    public class Repository : IRepository
    {
        private readonly SQLiteConnection _connection;

        private readonly IMappingService _mappingService;

        public Repository(IFileManager fileManager, IMappingService mappingService)
        {
            _mappingService = mappingService;

            var sqliteDbFilePath = fileManager.GetSqliteDbFilePath("cnt.db3");

            _connection = new SQLiteConnection(sqliteDbFilePath,
                SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            new MigrationManager(_connection).ApplyMigrations(true);
        }

        public ListContactsResult ListContacts(IPaginationInfo pagination)
        {
            var contacts = _connection.Table<Contact>().ToList();

            var result = new ListContactsResult
            {
                Contacts = contacts
                //PaginatedListInfo = _mappingService.Map<PaginatedListInfo>(pagination)
            };

            return result;
        }
    }
}