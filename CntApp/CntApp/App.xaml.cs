using CntApp.Master;
using CntApp.Utilities.Dependencies;
using CntApp.Utilities.Reflection;
using Xamarin.Forms;

namespace CntApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyRegistry.Init();

            MainPage = new Starting();

            //var embeddedResources = new ReflectionHelper().ListAllEmbeddedResources();
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