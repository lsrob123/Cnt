using System;
using CntApp.Domains.Home;
using CntApp.Utilities.Messages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Domains.Footers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FooterBar : Grid
    {
        public FooterBar()
        {
            InitializeComponent();
        }

        private void HomeTapped(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, nameof(OpenDetailPageMessage), new OpenDetailPageMessage(nameof(HomePage)));
        }
    }
}