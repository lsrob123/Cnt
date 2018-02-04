using Lx.Utilities.NetStandard.Persistence;
using Lx.Utilities.NetStandard.PersonName;
using SQLite;
using Xamarin.Forms.Internals;

namespace CntApp.Domains.Contacts
{
    [Preserve(AllMembers = true)]
    public class ContactPm : SqLitePersistenceModelBase, IContact
    {
        [MaxLength(50)]
        public string FamilyName { get; set; }

        [MaxLength(50)]
        public string GivenName { get; set; }

        public ContactPm WithPersonName(IPersonName personName)
        {
            FamilyName = personName.FamilyName;
            GivenName = personName.GivenName;
            return this;
        }
    }
}