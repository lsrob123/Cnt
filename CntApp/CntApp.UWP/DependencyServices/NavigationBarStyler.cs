using CntApp.Domains.NavigationBar;
using CntApp.UWP.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationBarStyler))]

namespace CntApp.UWP.DependencyServices
{
    public class NavigationBarStyler : NavigationBarStylerBase
    {
    }
}