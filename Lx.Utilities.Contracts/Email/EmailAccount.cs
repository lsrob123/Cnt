namespace Lx.Utilities.Contracts.Email
{
    public class EmailAccount : IEmailAccount
    {
        public string EmailAddress { get; set; }
        public string EmailAccountName { get; set; }
    }
}