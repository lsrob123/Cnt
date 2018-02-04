namespace Lx.Utilities.Contracts.PersonName
{
    public interface IPersonName
    {
        string DisplayName { get; }
        string FamilyName { get; }
        string GivenName { get; }
    }
}