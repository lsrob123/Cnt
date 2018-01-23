using Lx.Utilities.Xamarin;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : AdaptiveContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }
    }
}