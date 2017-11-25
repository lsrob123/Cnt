using CntApp.Utilities.Dependencies;
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
        }
    }
}