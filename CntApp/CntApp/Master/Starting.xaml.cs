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

            Detail = new NavigationPage(DependencyRegistry.HomeView);

            MessagingCenter.Subscribe<StartingMaster, OpenDetailPageMessage>(this, nameof(OpenDetailPageMessage),
                (sender, message) => OpenDetailPage(message));
        }

        private void OpenDetailPage(OpenDetailPageMessage message)
        {
            Detail = new NavigationPage(DependencyRegistry.ResolveViewByName(message.Data));

            if (!MasterBehavior.Equals(MasterBehavior.Split) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnLandscape) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnPortrait))
                IsPresented = false;
        }
    }
}