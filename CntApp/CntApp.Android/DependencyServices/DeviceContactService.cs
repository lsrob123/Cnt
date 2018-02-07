using System;
using System.Collections.Generic;
using Android.Provider;
using CntApp.Domains.Contacts;
using CntApp.Droid.DependencyServices;
using Lx.Utilities.NetStandard.Persistence;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceContactService))]

namespace CntApp.Droid.DependencyServices
{
    public class DeviceContactService : IDeviceContactService
    {
        public ICollection<Contact> ListContacts()
        {
            var uri = ContactsContract.Contacts.ContentUri;

            string[] projection =
            {
                ContactsContract.Contacts.InterfaceConsts.Id,
                ContactsContract.Contacts.InterfaceConsts.DisplayName,
                //ContactsContract.CommonDataKinds.Email.DisplayName,
                //ContactsContract.CommonDataKinds.Email.Address
                //ContactsContract.CommonDataKinds.Phone.Number,
                //ContactsContract.CommonDataKinds.Phone.NormalizedNumber
                //ContactsContract.ContactsColumns.ContactLastUpdatedTimestamp,
                //ContactsContract.Contacts.InterfaceConsts.PhotoId,
                //ContactsContract.Contacts.InterfaceConsts.PhotoUri,
                //ContactsContract.Contacts.InterfaceConsts.PhotoFileId,
                //ContactsContract.Contacts.InterfaceConsts.PhotoThumbnailUri
            };

            var contextContentResolver = Android.App.Application.Context.ContentResolver;
            var cursor = contextContentResolver.Query(uri, projection, null, null, null);
            var contacts = new List<Contact>();
            if (!cursor.MoveToFirst())
                return contacts;

            do
            {
                try
                {
                    var displayName = cursor.GetString(cursor.GetColumnIndex(projection[1]));
                    //var emailDisplayName = cursor.GetString(cursor.GetColumnIndex(projection[2]));
                    //var emailAddress = cursor.GetString(cursor.GetColumnIndex(projection[3]));

                    var contact = new Contact().WithValidKey()
                        .WithDisplayName(displayName)
                        //.WithEmail(emailDisplayName, emailAddress)
                        ;
                    contacts.Add(contact);
                }
                catch (Exception ex)
                {
                    var a = ex;
                }
            } while (cursor.MoveToNext());

            cursor.Close();

            return contacts;

        }
    }
}