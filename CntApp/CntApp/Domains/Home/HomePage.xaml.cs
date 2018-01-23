using CntApp.Utilities.States;
using Lx.Utilities.Xamarin;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : AdaptiveContentPage
    {
        private readonly ILocalStateStore _localStateStore;

        public HomePage(ILocalStateStore localStateStore)
        {
            InitializeComponent();
            _localStateStore = localStateStore;
        }
    }
}