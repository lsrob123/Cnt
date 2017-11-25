using CntApp.Utilities.StateStore;
using Xamarin.Forms;

namespace CntApp.Utilities.Views
{
    public abstract class ContentViewBase : ContentPage
    {
        protected readonly ILocalStateStore LocalStateStore;

        protected ContentViewBase(ILocalStateStore localStateStore)
        {
            LocalStateStore = localStateStore;
        }
    }
}