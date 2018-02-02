using System.Threading.Tasks;
using CntApp.Utilities.Persistence;
using Lx.Utilities.NetStandard.Pagination;

namespace CntApp.Domains.Contacts {
    public class ContactsService : IContactsService {
        private readonly IRepository _repository;

        public ContactsService(IRepository repository) {
            _repository = repository;
        }

        public async Task<ListContactsResult> ListContactsAsync(IPaginationInfo pagination) {
            var result = await _repository.ListContactsAsync(pagination);
            return result;
        }

    }
}