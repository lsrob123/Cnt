namespace Lx.Utilities.Contracts.PersonName {
    public class PersonName : IPersonName
    {
        public string DisplayName { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
    }
}