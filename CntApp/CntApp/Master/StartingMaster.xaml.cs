﻿using System;
using CntApp.Domains.Contacts;
using CntApp.Domains.Home;
using CntApp.Utilities.Messages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartingMaster : ContentPage
    {
        public ListView ListView;

        public StartingMaster()
        {
            InitializeComponent();
        }

        private void HomeTapped(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, nameof(OpenDetailPageMessage), new OpenDetailPageMessage(nameof(HomeView)));
        }

        private void ContactsTapped(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, nameof(OpenDetailPageMessage), new OpenDetailPageMessage(nameof(ContactsView)));
        }
    }
}