using System;
using Lx.Utilities.NetStandard.PersonName;

namespace CntApp.Domains.Contacts {
    public class Contact {
        public Guid Key { get; set; }
        public PersonName PersonName { get; set; }
    }
}