using Lx.Utilities.Xamarin.Pages;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Contacts {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : AdaptiveContentPage {

        public ContactsPage(ContactsViewModel contactsViewModel) {
            InitializeComponent();

            BindingContext = contactsViewModel;
        }
    }
}