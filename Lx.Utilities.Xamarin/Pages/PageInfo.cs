namespace Lx.Utilities.Xamarin.Pages {
    public class PageInfo {
        public double Width { get; set; }
        public double Height { get; set; }
        public bool IsLandscape => Width > 0 && Height > 0 && Width > Height;
    }
}