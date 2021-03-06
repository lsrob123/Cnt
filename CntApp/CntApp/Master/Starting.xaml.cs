﻿using CntApp.Domains.Footers;
using CntApp.Domains.Home;
using CntApp.Utilities.Dependencies;
using CntApp.Utilities.Messages;
using Plugin.DeviceInfo;
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

            Master = new StartingMaster(DependencyRegistry.LocalStateStore);

            OpenDetailPage(new OpenDetailPageMessage(nameof(HomePage)));

            MessagingCenter.Subscribe<StartingMaster, OpenDetailPageMessage>(this, nameof(OpenDetailPageMessage),
                (sender, message) => OpenDetailPage(message));

            MessagingCenter.Subscribe<FooterBar, OpenDetailPageMessage>(this, nameof(OpenDetailPageMessage),
                (sender, message) => OpenDetailPage(message));

            MasterBehavior = MasterBehavior.Popover;
        }

        private void OpenDetailPage(OpenDetailPageMessage message)
        {
            Detail = DependencyRegistry.ResolveDetailPage(message.Data);

            if (!MasterBehavior.Equals(MasterBehavior.Split) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnLandscape) &&
                !MasterBehavior.Equals(MasterBehavior.SplitOnPortrait))
                IsPresented = false;
        }
    }
}