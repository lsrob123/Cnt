using System.Threading.Tasks;
using Lx.Utilities.NetStandard.Pagination;

namespace CntApp.Domains.Contacts {
    public interface IContactsService {
        Task<ListContactsResult> ListContactsAsync(IPaginationInfo pagination);
    }
}