using System;
using Lx.Utilities.Xamarin.Pages;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Home {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : AdaptiveContentPage {
        public HomePage() {
            InitializeComponent();
        }

        protected override void AdditionalSizeChangedCallback(object sender, EventArgs e, PageInfo pageInfo) {
            LblPageInfo.Text = $"W:{pageInfo.Width},H:{pageInfo.Height},Landscape:{pageInfo.IsLandscape}";
        }
    }
}