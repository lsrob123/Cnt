using System;
using CntApp.Config;
using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Messages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartingMaster : ContentPage
    {
        public ListView ListView;

        public StartingMaster()
        {
            InitializeComponent();

            ProfileView.BindingContext = DependencyRegistry.MyProfileViewModel;
        }

        private void HomeTapped(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, nameof(OpenDetailPageMessage), new OpenDetailPageMessage(nameof(HomePage)));
        }

        private void ContactsTapped(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, nameof(OpenDetailPageMessage), new OpenDetailPageMessage(nameof(ContactsPage)));
        }
    }
}