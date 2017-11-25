using CntApp.Utilities.StateStore;
using CntApp.Utilities.Views;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentViewBase
    {
        public HomeView(ILocalStateStore localStateStore) : base(localStateStore)
        {
            InitializeComponent();
        }
    }
}