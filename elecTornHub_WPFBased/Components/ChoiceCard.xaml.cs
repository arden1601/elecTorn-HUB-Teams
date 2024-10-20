using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Components
{
    public partial class ChoiceCard : UserControl
    {
        public enum ChoiceCardType
        {
            Default,
            Post,
            Product
        }

        public ChoiceCard()
        {
            InitializeComponent();
            this.DataContext = this; // Set DataContext to itse
            this.Card_PostMode_Button.Visibility = Visibility.Collapsed;
            this.Card_ProductMode.Visibility = Visibility.Collapsed;
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(ChoiceCardType), typeof(ChoiceCard), new PropertyMetadata(ChoiceCardType.Default, OnTypeChange));
        public ChoiceCardType Type
            {
            get { return (ChoiceCardType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        public static void OnTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ChoiceCard;
            ChoiceCardType newType = (ChoiceCardType)e.NewValue;

            if (control == null)
                return;

            if (newType == ChoiceCardType.Post)
            {
                control.Card_PostMode_Button.Visibility = Visibility.Visible;

            }
            else if (newType == ChoiceCardType.Product)
            {
                control.Card_ProductMode.Visibility = Visibility.Visible;
            }
        }
    }
}
