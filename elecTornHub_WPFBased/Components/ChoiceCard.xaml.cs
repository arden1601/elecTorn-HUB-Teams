using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Components
{
    public partial class ChoiceCard : UserControl
    {
        public ChoiceCard()
        {
            InitializeComponent();
            this.DataContext = this; // Set DataContext to itse
            this.Card_PostMode_Button.Visibility = Visibility.Collapsed;
            this.Card_ProductMode.Visibility = Visibility.Collapsed;
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(ChoiceCard), new PropertyMetadata(string.Empty, OnTypeChange));
        public string Type
            {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        public static void OnTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ChoiceCard;
            string newType = e.NewValue as string;

            if (newType == "Post")
            {
                control.Card_PostMode_Button.Visibility = Visibility.Visible;

            }
            else if (newType == "Product")
            {
                control.Card_ProductMode.Visibility = Visibility.Visible;
            }
        }
    }
}
