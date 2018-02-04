namespace Lx.Utilities.Contracts.Email
{
    public interface IEmailAccount
    {
        string EmailAddress { get; }
        string EmailDisplayName { get; }
    }
}