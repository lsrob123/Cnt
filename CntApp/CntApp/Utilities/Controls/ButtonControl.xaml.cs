using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Utilities.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonControl : Grid
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(ButtonControl));

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ButtonControl), Color.White);

        public static readonly BindableProperty HorizontalTextAlignmentProperty =
            BindableProperty.Create(nameof(HorizontalTextAlignment), typeof(TextAlignment), typeof(ButtonControl),
                TextAlignment.Center);

        public static readonly BindableProperty VerticalTextAlignmentProperty =
            BindableProperty.Create(nameof(VerticalTextAlignment), typeof(TextAlignment), typeof(ButtonControl),
                TextAlignment.Center);

        public static readonly BindableProperty TextMarginProperty =
            BindableProperty.Create(nameof(TextMargin), typeof(Thickness), typeof(ButtonControl),
                new Thickness(20, 0));

        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(nameof(Icon), typeof(string), typeof(ButtonControl));

        public ButtonControl()
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

        public TextAlignment HorizontalTextAlignment
        {
            get => (TextAlignment) GetValue(HorizontalTextAlignmentProperty);
            set => SetValue(HorizontalTextAlignmentProperty, value);
        }

        public TextAlignment VerticalTextAlignment
        {
            get => (TextAlignment) GetValue(VerticalTextAlignmentProperty);
            set => SetValue(VerticalTextAlignmentProperty, value);
        }

        public Thickness TextMargin
        {
            get => (Thickness) GetValue(TextMarginProperty);
            set => SetValue(TextMarginProperty, value);
        }

        public string Icon
        {
            get => (string) GetValue(IconProperty);
            set
            {
                SetValue(IconProperty, value);
                ButtonIcon.Source = ImageSource.FromResource(value);
            }
        }
    }
}