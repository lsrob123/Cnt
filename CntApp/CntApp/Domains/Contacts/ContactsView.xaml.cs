using CntApp.Utilities.States;
using CntApp.Utilities.Views;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsView : ContentViewBase
    {
        public ContactsView(ILocalStateStore localStateStore) : base(localStateStore)
        {
            InitializeComponent();
        }
    }
}