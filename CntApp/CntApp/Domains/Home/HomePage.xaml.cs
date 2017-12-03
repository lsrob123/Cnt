using CntApp.Utilities.States;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private readonly ILocalStateStore _localStateStore;

        public HomePage(ILocalStateStore localStateStore)
        {
            InitializeComponent();
            _localStateStore = localStateStore;
        }
    }
}