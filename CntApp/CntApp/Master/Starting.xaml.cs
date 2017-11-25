using CntApp.Domains.Home;
using CntApp.Utilities.Dependencies;
using CntApp.Utilities.Messages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Starting : MasterDetailPage
    {
        public Starting()
        {
            InitializeComponent();

            OpenDetailPage(new OpenDetailPageMessage(nameof(HomeView)));

            MessagingCenter.Subscribe<StartingMaster, OpenDetailPageMessage>(this, nameof(OpenDetailPageMessage),
                (sender, message) => OpenDetailPage(message));
        }

        private void OpenDetailPage(OpenDetailPageMessage message)
        {
            Detail = DependencyRegistry.ResolveDetailPage(message.Data);

            if (!MasterBehavior.Equals(MasterBehavior.Split) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnLandscape) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnPortrait))
                IsPresented = false;
        }
    }
}