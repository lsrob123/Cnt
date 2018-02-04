namespace Lx.Utilities.Contracts.Phone
{
    public class PhoneNumber : IPhoneNumber
    {
        public int? PhoneCountryCode { get; set; }
        public string PhoneNumberWithAreaCode { get; set; }
        public bool? PhoneIsMobile { get; set; }
        public string PhoneDescription { get; set; }
    }
}