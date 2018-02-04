using System.Collections.Generic;

namespace CntApp.Domains.Contacts
{
    public interface IDeviceContactService
    {
        ICollection<Contact> ListContacts();
    }
}