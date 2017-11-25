using CntApp.Domains.NavigationBar;
using CntApp.iOS.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationBarStyler))]

namespace CntApp.iOS.DependencyServices
{
    public class NavigationBarStyler : NavigationBarStylerBase
    {
    }
}