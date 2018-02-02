using System;
using Xamarin.Forms;

namespace Lx.Utilities.Xamarin.Pages {
    public abstract class AdaptiveContentPage : ContentPage {
        protected AdaptiveContentPage() {
            SizeChanged += AdaptiveContentPage_SizeChanged;

            ExecuteInit();
        }

        private void ExecuteInit() {
            Init();
        }

        protected abstract void Init();

        protected virtual void AdditionalSizeChangedCallback(object sender, EventArgs e, PageInfo pageInfo) { }

        private void AdaptiveContentPage_SizeChanged(object sender, EventArgs e) {
            var pageInfo = new PageInfo {
                Width = Width,
                Height = Height
            };

            AdditionalSizeChangedCallback(sender, e, pageInfo);
        }
    }
}