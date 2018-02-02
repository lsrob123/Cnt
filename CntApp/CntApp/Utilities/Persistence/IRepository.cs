using System.Collections.Generic;
using System.Threading.Tasks;
using CntApp.Domains.Contacts;
using Lx.Utilities.NetStandard.Pagination;

namespace CntApp.Utilities.Persistence {
    public interface IRepository {
        Task<ListContactsResult> ListContactsAsync(IPaginationInfo pagination);
    }
}