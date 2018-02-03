using System.Linq;
using CntApp.Domains.Contacts;
using CntApp.Utilities.Files;
using Lx.Utilities.Contracts.Mapping;
using Lx.Utilities.NetStandard.Pagination;
using Lx.Utilities.NetStandard.Persistence;
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
            //_connection = new SQLiteConnection(sqliteDbFilePath);

            new MigrationManager(_connection).ApplyMigrations(true);
        }

        public ListContactsResult ListContacts(IPaginationInfo pagination)
        {
            var contactPms = _connection.Table<ContactPm>().ToList();
            var contacts = contactPms.Select(x => new Contact().WithValidKey(x.Key).WithPersonName(x))
                .ToList();

            var result = new ListContactsResult
            {
                Contacts = contacts
                //PaginatedListInfo = _mappingService.Map<PaginatedListInfo>(pagination)
            };

            return result;
        }
    }
}