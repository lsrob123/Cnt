using CntApp._StateStore;
using Xamarin.Forms;

namespace CntApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            LocalStateStore.Start();

            MainPage = new MainPage();
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