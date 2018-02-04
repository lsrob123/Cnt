using Lx.Utilities.Contracts.PersonName;
using Lx.Utilities.NetStandard.Persistence;
using SQLite;
using Xamarin.Forms.Internals;

namespace CntApp.Domains.Contacts
{
    [Preserve(AllMembers = true)]
    public class Contact : SqLitePersistenceModelBase, IContact
    {
        [MaxLength(50)]
        public string DisplayName { get; protected set; }

        [MaxLength(50)]
        public string FamilyName { get; protected set; }

        [MaxLength(50)]
        public string GivenName { get; protected set; }

        [MaxLength(200)]
        public string EmailAddress { get; protected set; }

        [MaxLength(50)]
        public string EmailDisplayName { get; protected set; }

        public int? PhoneCountryCode { get; protected set; }

        [MaxLength(100)]
        public string PhoneNumberWithAreaCode { get; protected set; }

        public bool? PhoneIsMobile { get; protected set; }

        [MaxLength(50)]
        public string PhoneDescription { get; protected set; }

        public Contact WithPersonName(IPersonName personName)
        {
            WithDisplayName(personName.DisplayName);
            FamilyName = personName.FamilyName;
            GivenName = personName.GivenName;
            return this;
        }

        public Contact WithDisplayName(string displayName)
        {
            DisplayName = displayName;
            return this;
        }

    }
}