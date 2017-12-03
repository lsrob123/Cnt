using System;
using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Utilities.Messages;
using CntApp.Utilities.States;
using FFImageLoading.Svg.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartingMaster : ContentPage
    {
        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private readonly ILocalStateStore _localStateStore;

        public ListView ListView;

        public StartingMaster(ILocalStateStore localStateStore)
        {
            InitializeComponent();
            _localStateStore = localStateStore;

            MyProfileView.BindingContext = _localStateStore.MyProfileViewModel;
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