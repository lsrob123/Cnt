using CntApp.Utilities.Persistence;
using Lx.Utilities.NetStandard.Pagination;

namespace CntApp.Domains.Contacts
{
    public class ContactsService : IContactsService
    {
        private readonly IRepository _repository;

        public ContactsService(IRepository repository)
        {
            _repository = repository;
        }

        public ListContactsResult ListContacts(IPaginationInfo pagination)
        {
            var result = _repository.ListContacts(pagination);
            return result;
        }
    }
}