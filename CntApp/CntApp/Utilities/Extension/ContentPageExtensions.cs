using System.Collections.Generic;
using Xamarin.Forms;

namespace CntApp.Utilities.Extension
{
    public static class ContentPageExtensions
    {
        public static void AttachToolbarItems(this ContentPage contentPage, IEnumerable<ToolbarItem> toolbarItems)
        {
            foreach (var toolbarItem in toolbarItems)
                contentPage.ToolbarItems.Add(toolbarItem);
        }
    }
}