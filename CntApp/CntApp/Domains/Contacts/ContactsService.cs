using CntApp.Utilities.Persistence;
using Lx.Utilities.NetStandard.Pagination;

namespace CntApp.Domains.Contacts
{
    public class ContactsService : IContactsService
    {
        private readonly IDeviceContactService _deviceContactService;
        private readonly IRepository _repository;

        public ContactsService(IRepository repository, IDeviceContactService deviceContactService)
        {
            _repository = repository;
            _deviceContactService = deviceContactService;
        }

        public ListContactsResult ListContacts(IPaginationInfo pagination)
        {
            //var result = _repository.ListContacts(pagination);

            var contacts = _deviceContactService.ListContacts();
            var result = new ListContactsResult
            {
                Contacts = contacts
            };
            return result;
        }
    }
}