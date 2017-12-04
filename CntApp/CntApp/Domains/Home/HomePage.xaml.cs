using System.Collections.Generic;
using CntApp.Utilities.Extension;
using CntApp.Utilities.States;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private readonly ILocalStateStore _localStateStore;

        public HomePage(ILocalStateStore localStateStore, IEnumerable<ToolbarItem> toolbarItems)
        {
            InitializeComponent();
            //this.AttachToolbarItems(toolbarItems);

            _localStateStore = localStateStore;
        }
    }
}