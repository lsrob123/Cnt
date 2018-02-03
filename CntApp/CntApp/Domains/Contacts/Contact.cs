using Lx.Utilities.NetStandard.Persistence;
using Lx.Utilities.NetStandard.PersonName;

namespace CntApp.Domains.Contacts
{
    public class Contact : EntityBase, IContact
    {
        //public PersonName PersonName { get; set; }

        public Contact WithPersonName(IPersonName personName)
        {
            FamilyName = personName.FamilyName;
            GivenName = personName.GivenName;
            return this;
        }

        public string FamilyName { get; protected set; }
        public string GivenName { get; protected set; }
    }
}