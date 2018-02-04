using Lx.Utilities.Contracts.Email;
using Lx.Utilities.Contracts.PersonName;
using Lx.Utilities.Contracts.Phone;
using Lx.Utilities.NetStandard.Persistence;

namespace CntApp.Domains.Contacts
{
    public interface IContact : IEntity, IPersonName, IEmailAccount, IPhoneNumber
    {
    }
}