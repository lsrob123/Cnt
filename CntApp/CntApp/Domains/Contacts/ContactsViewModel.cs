using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lx.Utilities.NetStandard.Pagination;
using Lx.Utilities.Xamarin.Etc;

namespace CntApp.Domains.Contacts {
    public class ContactsViewModel : INotifyPropertyChanged {
        private readonly ICollection<Contact> _contacts = new List<Contact>();

        private readonly IContactsService _contactsService;

        public ContactsViewModel(IContactsService contactsService) {
            _contactsService = contactsService;

            var result = _contactsService.ListContactsAsync(new PaginationInfo {PageNumber = 1, PageSize = 10}).Result;
            Contacts = result.Contacts;
        }

        public ICollection<Contact> Contacts {
            get => _contacts;
            set {
                _contacts.Clear();
                foreach (var contact in value)
                    _contacts.Add(contact);

                OnPropertyChanged(nameof(Contacts));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}