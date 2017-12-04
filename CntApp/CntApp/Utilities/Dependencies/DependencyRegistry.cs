using System;
using System.Collections.Generic;
using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Domains.MyProfile;
using CntApp.Domains.NavigationBar;
using CntApp.Utilities.DB;
using CntApp.Utilities.Files;
using CntApp.Utilities.Messages;
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

        public static HomePage HomePage => new HomePage(LocalStateStore, DefaultToolbarItems);
        public static ContactsPage ContactsPage => new ContactsPage();

        public static MyProfileViewModel MyProfileViewModel { get; private set; }

        public static List<ToolbarItem> DefaultToolbarItems { get; private set; }

        public static void Init()
        {
            LocalDb = new LocalDb(FilePathResolver);
            LocalStateStore = new LocalStateStore();

            MyProfileViewModel = new MyProfileViewModel
            {
                ImageFilePath = FilePathResolver.MyProfileImagePath,
#if DEBUG
                FullName = "Linda Jones",
                Nickname = "The Queen",
                Mobile = "0412 345 678",
                Email = "linda.jones@deepentech.com"
#endif
            };

            //var logoutToobarItem = new ToolbarItem("Logout", null, null, ToolbarItemOrder.Secondary, 1);
            var logoutToobarItem = new ToolbarItem
            {
                Text = "Logout",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
            };
            logoutToobarItem.Clicked += LogoutToobarItem_Clicked;
            DefaultToolbarItems = new List<ToolbarItem>
            {
                logoutToobarItem
            };
        }

        private static void LogoutToobarItem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(sender, nameof(LogOutMessage), new LogOutMessage(null));
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