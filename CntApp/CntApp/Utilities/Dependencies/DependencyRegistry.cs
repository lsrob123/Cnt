using AutoMapper;
using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Domains.MyProfile;
using CntApp.Domains.NavigationBar;
using CntApp.Utilities.Files;
using CntApp.Utilities.Persistence;
using Lx.Utilities.Contracts.Mapping;
using Lx.Utilities.NetStandard.Mapping;
using Xamarin.Forms;

namespace CntApp.Utilities.Dependencies {
    public static class DependencyRegistry {
        public static IMappingService MappingService;
        public static IRepository Repository;

        public static IContactsService ContactsService;
        public static ContactsViewModel ContactsViewModel;

        public static IFileManager FileManager => DependencyService.Get<IFileManager>();
        public static INavigationBarStyler NavigationBarStyler => DependencyService.Get<INavigationBarStyler>();

        public static HomePage HomePage => new HomePage();

        public static MyProfileViewModel MyProfileViewModel { get; private set; }
        public static ContactsPage ContactsPage => new ContactsPage(ContactsViewModel);

        public static void Init() {
            MappingService = new MappingService(new MapperConfiguration(x => x.CreateMissingTypeMaps = true));

            Repository = new Repository(FileManager, MappingService);

            MyProfileViewModel = new MyProfileViewModel {
                ImageFilePath = FileManager.MyProfileImagePath,

#if DEBUG
                // TODO: Move to seeding with repository
                FullName = "Linda Jones",
                Nickname = "The Queen",
                Mobile = "0412 345 678",
                Email = "linda.jones@deepentech.com"
#endif
            };

            ContactsService = new ContactsService(Repository);
            ContactsViewModel = new ContactsViewModel(ContactsService);
        }

        public static NavigationPage ResolveDetailPage(string detailPageName) {
            switch (detailPageName) {
                case nameof(Domains.Contacts.ContactsPage):
                    return CreateDetailPage(ContactsPage);
                default:
                    return CreateDetailPage(HomePage);
            }
        }

        private static NavigationPage CreateDetailPage(Page view) {
            return NavigationBarStyler.Style(new NavigationPage(view));
        }
    }
}