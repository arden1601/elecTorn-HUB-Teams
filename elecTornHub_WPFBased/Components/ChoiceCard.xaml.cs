using System.Windows;
using System.Windows.Controls;

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
            this.DataContext = this;

            // Ensure default visibility is set up
            OnTypeChange(this, new DependencyPropertyChangedEventArgs(TypeProperty, null, Type));
            OnGridModeChanged(this, new DependencyPropertyChangedEventArgs(GridModeProperty, null, GridMode));
        }


        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(ChoiceCardType), typeof(ChoiceCard), new PropertyMetadata(ChoiceCardType.Default, OnTypeChange));

        public ChoiceCardType Type
        {
            get { return (ChoiceCardType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // DependencyProperty for GridMode
        public static readonly DependencyProperty GridModeProperty =
            DependencyProperty.Register("GridMode", typeof(CustomGrid.CustomGridMode), typeof(ChoiceCard), new PropertyMetadata(CustomGrid.CustomGridMode.Default, OnGridModeChanged));

        public CustomGrid.CustomGridMode GridMode
        {
            get { return (CustomGrid.CustomGridMode)GetValue(GridModeProperty); }
            set { SetValue(GridModeProperty, value); }
        }

        // Callback for TypeProperty change
        public static void OnTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ChoiceCard;
            if (control == null) return;

            var newType = (ChoiceCardType)e.NewValue;

            // Handle visibility based on Type
            if (newType == ChoiceCardType.Post)
            {
                control.Card_PostMode_Button.Visibility = Visibility.Visible;
                control.Card_ProductMode.Visibility = Visibility.Collapsed;
            }
            else if (newType == ChoiceCardType.Product)
            {
                control.Card_PostMode_Button.Visibility = Visibility.Collapsed;
                control.Card_ProductMode.Visibility = Visibility.Visible;
            }
            else
            {
                control.Card_PostMode_Button.Visibility = Visibility.Collapsed;
                control.Card_ProductMode.Visibility = Visibility.Collapsed;
            }
        }

        // Callback for GridMode change
        public static void OnGridModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ChoiceCard;
            if (control == null) return;

            var newMode = (CustomGrid.CustomGridMode)e.NewValue;

            // Update button content based on GridMode
            if (newMode == CustomGrid.CustomGridMode.Admin)
            {
                control.ProductCard_Button.Content = "Periksa";
            }
            else if (newMode == CustomGrid.CustomGridMode.Beli)
            {
                control.ProductCard_Button.Content = "Beli Sekarang";
            }
            else if (newMode == CustomGrid.CustomGridMode.Jual)
            {
                control.ProductCard_Button.Content = "Edit";
            }
        }
    }
}
