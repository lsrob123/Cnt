using System;
using System.Collections.Generic;
using CntApp.Domains.Contacts;
using CntApp.iOS.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceContactService))]
namespace CntApp.iOS.DependencyServices
{
    public class DeviceContactService : IDeviceContactService
    {
        public ICollection<Contact> ListContacts()
        {
            throw new NotImplementedException();
        }
    }
}