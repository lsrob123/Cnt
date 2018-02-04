using CntApp.Master;
using CntApp.Utilities.Config;
using Lx.Utilities.Contracts.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//using Realms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace CntApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyRegistry.Init();

#if DEBUG
            var embeddedResources = new ReflectionHelper().ListAllEmbeddedResources();
#endif

            MainPage = new Starting(DependencyRegistry.ResolveDetailPage);
        }

        protected override void OnStart()
        {
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