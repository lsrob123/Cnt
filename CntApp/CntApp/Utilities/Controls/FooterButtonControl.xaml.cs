using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Utilities.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FooterButtonControl : Grid
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(ButtonControl));

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ButtonControl), Color.White);

        public static readonly BindableProperty SvgIconSourceProperty =
            BindableProperty.Create(nameof(SvgIconSource), typeof(string), typeof(ButtonControl));

        public FooterButtonControl()
        {
            InitializeComponent();
        }

        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public Color TextColor
        {
            get => (Color) GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public string SvgIconSource
        {
            get => (string) GetValue(SvgIconSourceProperty);
            set => SetValue(SvgIconSourceProperty, value);
        }
    }
}