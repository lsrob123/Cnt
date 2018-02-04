namespace Lx.Utilities.Contracts.Phone
{
    public interface IPhoneNumber
    {
        int? PhoneCountryCode { get; }
        string PhoneNumberWithAreaCode { get; }
        bool? PhoneIsMobile { get; }
        string PhoneDescription { get; }
    }
}