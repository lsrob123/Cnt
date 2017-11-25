using Xamarin.Forms;

namespace CntApp.Domains.NavigationBar
{
    public abstract class NavigationBarStylerBase : INavigationBarStyler
    {
        public virtual NavigationPage Style(NavigationPage page)
        {
            page.BarBackgroundColor = (Color) Application.Current.Resources["BarBackground"];
            page.BarTextColor = (Color) Application.Current.Resources["BarText"];

            return page;
        }
    }
}