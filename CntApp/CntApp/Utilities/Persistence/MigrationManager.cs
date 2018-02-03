using System.Collections.Generic;
using CntApp.Domains.Contacts;
using Lx.Utilities.NetStandard.Persistence;
using Lx.Utilities.NetStandard.PersonName;
using SQLite;

namespace CntApp.Utilities.Persistence
{
    public class MigrationManager
    {
        private readonly SQLiteConnection _connection;

        public MigrationManager(SQLiteConnection connection)
        {
            _connection = connection;
        }

        public void ApplyMigrations(bool applySeeds)
        {
            _connection.CreateTable<ContactPm>();

            if (applySeeds)
                ApplySeeds();
        }

        private void ApplySeeds()
        {
            var contactPms = ContactPmSeeds();

            foreach (var contactPm in contactPms)
            {
                var existingContact = _connection
                    .Table<ContactPm>()
                    .FirstOrDefault(x => x.FamilyName == contactPm.FamilyName && x.GivenName == contactPm.GivenName);
                if (existingContact == null)
                    _connection.Insert(contactPm);
            }
        }

        public static ICollection<ContactPm> ContactPmSeeds()
        {
            var contactPms = new List<ContactPm>
            {
                new ContactPm().WithValidKey()
                    .WithPersonName(new PersonName {FamilyName = "abc", GivenName = "123"}),
                new ContactPm().WithValidKey()
                    .WithPersonName(new PersonName {FamilyName = "def", GivenName = "456"})
            };
            return contactPms;
        }
    }
}