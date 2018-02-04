using System;
using System.Collections.Generic;
using CntApp.Domains.Contacts;
using Xamarin.Forms;

[assembly: Dependency(typeof(IDeviceContactService))]
namespace CntApp.Droid.DependencyServices
{
    public class DeviceContactService : IDeviceContactService
    {
        public ICollection<Contact> ListContacts()
        {
            throw new NotImplementedException();
        }
    }
}