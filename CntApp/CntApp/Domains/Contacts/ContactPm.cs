using Lx.Utilities.NetStandard.Persistence;
using Lx.Utilities.NetStandard.PersonName;
using SQLite;
using Xamarin.Forms.Internals;

namespace CntApp.Domains.Contacts
{
    [Preserve(AllMembers = true)]
    public class ContactPm : SqLitePersistenceModelBase, IContact
    {
        //public PersonName PersonName { get; set; }

        //public ContactPersistenceModel WithPersonName(PersonName personName)
        //{
        //    PersonName = personName;
        //    return this;
        //}

        public ContactPm WithPersonName(IPersonName personName)
        {
            FamilyName = personName.FamilyName;
            GivenName = personName.GivenName;
            return this;
        }

        public string FamilyName { get; set; }
        public string GivenName { get; set; }
    }
}