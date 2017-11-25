using CntApp.Domains.NavigationBar;
using CntApp.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationBarStyler))]

namespace CntApp.Droid.DependencyServices
{
    public class NavigationBarStyler : NavigationBarStylerBase
    {
    }
}