using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Domains.NavigationBar;
using CntApp.Utilities.DB;
using CntApp.Utilities.Files;
using CntApp.Utilities.States;
using Xamarin.Forms;

namespace CntApp.Utilities.Dependencies
{
    public static class DependencyRegistry
    {
        public static ILocalDb LocalDb { get; private set; }
        public static ILocalStateStore LocalStateStore { get; private set; }

        public static IFilePathResolver FilePathResolver => DependencyService.Get<IFilePathResolver>();
        public static INavigationBarStyler NavigationBarStyler => DependencyService.Get<INavigationBarStyler>();

        public static HomePage HomePage => new HomePage(LocalStateStore);
        public static ContactsPage ContactsPage => new ContactsPage();

        public static void Init()
        {
            LocalDb = new LocalDb(FilePathResolver);
            LocalStateStore = new LocalStateStore(LocalDb);
        }

        public static NavigationPage ResolveDetailPage(string detailPageName)
        {
            switch (detailPageName)
            {
                case nameof(Domains.Contacts.ContactsPage):
                    return CreateDetailPage(ContactsPage);
                default:
                    return CreateDetailPage(HomePage);
            }
        }

        private static NavigationPage CreateDetailPage(Page view)
        {
            return NavigationBarStyler.Style(new NavigationPage(view));
        }
    }
}