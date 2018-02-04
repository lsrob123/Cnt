using System.Collections.Generic;
using CntApp.Domains.Contacts;
using Lx.Utilities.Contracts.PersonName;
using Lx.Utilities.NetStandard.Persistence;
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
            _connection.CreateTable<Contact>();
            _connection.CreateIndex<Contact>(t => t.Key, true);

            _connection.CreateTable<AdditionalPhoneNumber>();
            _connection.CreateIndex<AdditionalPhoneNumber>(t => t.Key, true);

            if (applySeeds)
                ApplySeeds();
        }

        private void ApplySeeds()
        {
            var contactPms = ContactPmSeeds();

            foreach (var contactPm in contactPms)
            {
                var existingContact = _connection
                    .Table<Contact>()
                    .FirstOrDefault(x => x.FamilyName == contactPm.FamilyName && x.GivenName == contactPm.GivenName);
                if (existingContact == null)
                    _connection.Insert(contactPm);
            }
        }

        public static ICollection<Contact> ContactPmSeeds()
        {
            var contactPms = new List<Contact>
            {
                new Contact().WithValidKey()
                    .WithPersonName(new PersonName {FamilyName = "abc", GivenName = "123"}),
                new Contact().WithValidKey()
                    .WithPersonName(new PersonName {FamilyName = "def", GivenName = "456"})
            };
            return contactPms;
        }
    }
}