using System.Threading.Tasks;
using Lx.Utilities.NetStandard.Pagination;

namespace CntApp.Domains.Contacts {
    public interface IContactsService {
        ListContactsResult ListContacts(IPaginationInfo pagination);
    }
}