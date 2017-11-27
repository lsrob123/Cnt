using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Utilities.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentGridView : Grid
    {
        public ContentGridView()
        {
            InitializeComponent();
        }
    }
}