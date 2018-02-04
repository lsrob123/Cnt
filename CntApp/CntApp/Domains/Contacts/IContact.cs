using Lx.Utilities.NetStandard.Persistence;
using Lx.Utilities.NetStandard.PersonName;

namespace CntApp.Domains.Contacts
{
    public interface IContact : IEntity, IPersonName
    {
    }
}