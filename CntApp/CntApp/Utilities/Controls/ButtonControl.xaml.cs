﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CntApp.Utilities.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonControl : ContentView
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
    }
}