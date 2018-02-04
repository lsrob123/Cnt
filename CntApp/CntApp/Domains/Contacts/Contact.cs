using System.ComponentModel.DataAnnotations;
using Lx.Utilities.NetStandard.Persistence;
using Lx.Utilities.NetStandard.PersonName;

namespace CntApp.Domains.Contacts
{
    public class Contact : EntityBase, IContact
    {
        [StringLength(50)]
        public string FamilyName { get; protected set; }

        [StringLength(50)]
        public string GivenName { get; protected set; }

        public Contact WithPersonName(IPersonName personName)
        {
            FamilyName = personName.FamilyName;
            GivenName = personName.GivenName;
            return this;
        }
    }
}