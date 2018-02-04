using System;
using System.Collections.Generic;
using CntApp.Domains.Contacts;
using CntApp.UWP.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceContactService))]
namespace CntApp.UWP.DependencyServices
{
    public class DeviceContactService : IDeviceContactService
    {
        public ICollection<Contact> ListContacts()
        {
            throw new NotImplementedException();
        }
    }
}