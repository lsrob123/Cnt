using System.Threading.Tasks;
using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Domains.MyProfile;
using CntApp.Domains.NavigationBar;
using CntApp.Utilities.Files;
using CntApp.Utilities.Persistence;
using Lx.Utilities.Contracts.Mapping;
using Lx.Utilities.NetStandard.Mapping;
using Xamarin.Forms;

namespace CntApp.Config
{
    public static class DependencyRegistry
    {
        public static IMappingService MappingService;
        public static IRepository Repository;

        public static IFileManager FileManager => DependencyService.Get<IFileManager>();
        public static INavigationBarStyler NavigationBarStyler => DependencyService.Get<INavigationBarStyler>();

        public static HomePage HomePage => new HomePage();

        public static MyProfileViewModel MyProfileViewModel { get; private set; }

        public static IDeviceContactService DeviceContactService => DependencyService.Get<IDeviceContactService>();
        public static IContactsService ContactsService;
        public static ContactsViewModel ContactsViewModel;
        public static ContactsPage ContactsPage => new ContactsPage(ContactsViewModel);

        /// <summary>
        ///     A seperate Init() for explicitly bootstrapping the DepedencyRegistry
        /// </summary>
        public static void Init()
        {
            MappingService = new MappingService(MappingConfigurator.CreateMapperConfiguration());

            MyProfileViewModel = new MyProfileViewModel
            {
                ImageFilePath = FileManager.MyProfileImagePath,

#if DEBUG
                // TODO: Move to seeding with repository
                FullName = "Linda Jones",
                Nickname = "The Queen",
                Mobile = "0412 345 678",
                Email = "linda.jones@deepentech.com"
#endif
            };

            Task.Delay(1000)
                //.ContinueWith(t=>Console.WriteLine($"Initializing DB and services {DateTimeOffset.UtcNow:yyyy-MM-dd HH:mm:ss.fff}."))
                .ContinueWith(t => Repository = new Repository(FileManager, MappingService))
                .ContinueWith(t => ContactsService = new ContactsService(t.Result, DeviceContactService))
                .ContinueWith(t => ContactsViewModel = new ContactsViewModel(t.Result))
                //.ContinueWith(t => Console.WriteLine($"Initialized DB and services {DateTimeOffset.UtcNow:yyyy-MM-dd HH:mm:ss.fff}."))
                ;
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