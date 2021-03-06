﻿using CntApp.Master;
using CntApp.Utilities.Dependencies;
using Lx.Utilities.Contracts.Reflection;
//using Realms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace CntApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyRegistry.Init();

            //var vRealmDb = Realm.GetInstance();

            MainPage = new Starting();

            var embeddedResources = new ReflectionHelper().ListAllEmbeddedResources();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}