using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Domains.MyProfile;
using CntApp.Domains.NavigationBar;
using CntApp.Utilities.DB;
using CntApp.Utilities.DB.Migrations;
using CntApp.Utilities.Files;
using CntApp.Utilities.States;
using Xamarin.Forms;

namespace CntApp.Utilities.Dependencies
{
    public static class DependencyRegistry
    {
        public static DbConfigurations DbConfigurations { get; private set; }
        public static ILocalDb LocalDb { get; private set; }
        public static ILocalStateStore LocalStateStore { get; private set; }

        public static IFileManager FileManager => DependencyService.Get<IFileManager>();
        public static INavigationBarStyler NavigationBarStyler => DependencyService.Get<INavigationBarStyler>();

        public static HomePage HomePage => new HomePage(LocalStateStore);
        public static ContactsPage ContactsPage => new ContactsPage();

        public static MyProfileViewModel MyProfileViewModel { get; private set; }

        public static void Init()
        {
            DbConfigurations = new DbConfigurations(FileManager);
            LocalDb = new LocalDb(DbConfigurations);

            MyProfileViewModel = new MyProfileViewModel
            {
                ImageFilePath = FileManager.MyProfileImagePath,
#if DEBUG
                FullName = "Linda Jones",
                Nickname = "The Queen",
                Mobile = "0412 345 678",
                Email = "linda.jones@deepentech.com"
#endif
            };

            LocalStateStore = new LocalStateStore();
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