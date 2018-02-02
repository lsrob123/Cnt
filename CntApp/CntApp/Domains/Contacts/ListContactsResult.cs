using System.Collections.Generic;
using Lx.Utilities.NetStandard.Pagination;
using Lx.Utilities.Xamarin.Etc;

namespace CntApp.Domains.Contacts {
    public class ListContactsResult : ResultBase {
        public ICollection<Contact> Contacts { get; set; }
        public PaginatedListInfo PaginatedListInfo { get; set; }
    }
}