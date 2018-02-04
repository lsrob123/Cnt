using System;
using Lx.Utilities.Contracts.Phone;
using Lx.Utilities.NetStandard.Persistence;
using SQLite;

namespace CntApp.Domains.Contacts
{
    public class AdditionalPhoneNumber : SqLitePersistenceModelBase, IPhoneNumber
    {
        public Guid ContactKey { get; protected set; }
        public int? PhoneCountryCode { get; protected set; }

        [MaxLength(100)]
        public string PhoneNumberWithAreaCode { get; protected set; }

        public bool? PhoneIsMobile { get; protected set; }

        [MaxLength(50)]
        public string PhoneDescription { get; protected set; }
    }
}