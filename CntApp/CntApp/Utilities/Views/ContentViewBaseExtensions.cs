namespace CntApp.Utilities.Views
{
    public static class ContentViewBaseExtensions
    {
        public static string GetTypeName<TView>(this TView view) where TView : ContentViewBase
        {
            return view.GetType().Name;
        }
    }
}