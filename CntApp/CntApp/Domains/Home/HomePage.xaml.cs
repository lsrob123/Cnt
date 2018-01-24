using System;
using CntApp.Utilities.States;
using Lx.Utilities.Xamarin.Pages;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Home {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : AdaptiveContentPage {
        private readonly ILocalStateStore _localStateStore;

        public HomePage(ILocalStateStore localStateStore) {
            InitializeComponent();
            _localStateStore = localStateStore;
        }

        protected override void AdditionalSizeChangedCallback(object sender, EventArgs e, PageInfo pageInfo) {
            LblPageInfo.Text = $"W:{pageInfo.Width},H:{pageInfo.Height},Landscape:{pageInfo.IsLandscape}";
        }
    }
}