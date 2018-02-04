using System;
using CntApp.Domains.Footers;
using CntApp.Domains.Home;
using CntApp.Utilities.Config;
using CntApp.Utilities.Messages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Starting : MasterDetailPage
    {
        private readonly Func<string, NavigationPage> _resolveDetailPage;

        public Starting(Func<string, NavigationPage> resolveDetailPage)
        {
            _resolveDetailPage = resolveDetailPage;

            InitializeComponent();

            Master = new StartingMaster();

            OpenDetailPage(new OpenDetailPageMessage(nameof(HomePage)));

            MessagingCenter.Subscribe<StartingMaster, OpenDetailPageMessage>(this, nameof(OpenDetailPageMessage),
                (sender, message) => OpenDetailPage(message));

            MessagingCenter.Subscribe<FooterBar, OpenDetailPageMessage>(this, nameof(OpenDetailPageMessage),
                (sender, message) => OpenDetailPage(message));

            MasterBehavior = MasterBehavior.Popover;
        }

        private void OpenDetailPage(OpenDetailPageMessage message)
        {
            Detail = _resolveDetailPage(message.Data);

            if (!MasterBehavior.Equals(MasterBehavior.Split) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnLandscape) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnPortrait))
                IsPresented = false;
        }
    }
}