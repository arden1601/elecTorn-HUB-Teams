namespace elecTornHub_WPFBased.Components
{
    using elecTornHub_WPFBased.Extras;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class OpenContentBody : UserControl
    {
        public OpenContentBody()
        {
            InitializeComponent();
            UpdateLayout();
            this.DataContext = this; // Set DataContext to itse
            OpenContentBody_ModePost.Visibility = Visibility.Collapsed;
            OpenContentBody_ModeProduct.Visibility = Visibility.Collapsed;

            // Hide all buttons and counter
            ClearProps(OpenContentBody_Button1);
            ClearProps(OpenContentBody_Button2);
            ClearProps(OpenContentBody_Button3);
            ClearProps(OpenContentBody_Counter);
            OpenContentBody_ReportTab.Visibility = Visibility.Collapsed;
            OpenContentBody_EditTitleBorder.Visibility = Visibility.Collapsed;
            OpenContentBody_EditDescBorder.Visibility = Visibility.Collapsed;
            OpenContentBody_EditPriceBorder.Visibility = Visibility.Collapsed;
        }

        private void ClearProps(Border border)
        {
            border.Visibility = Visibility.Hidden;
            border.Width = 0;
            border.Margin = new Thickness(0);
        }

        private void ClearProps(CounterButton button)
        {
            button.Visibility = Visibility.Hidden;
            button.Width = 0;
            button.Margin = new Thickness(0);
        }

        // DependencyProperty for Type
        public enum OpenContentBodyType
        {
            Default,
            Buyer,
            Seller,
            Reported,
            Banned
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(OpenContentBodyType), typeof(OpenContentBody), new PropertyMetadata(OpenContentBodyType.Default, OnTypeChanged));

        public OpenContentBodyType Type
        {
            get { return (OpenContentBodyType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // DependencyProperty for Mode
        public enum OpenContentBodyMode
        {
            Default,
            Product,
            Post
        }

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(OpenContentBodyMode), typeof(OpenContentBody), new PropertyMetadata(OpenContentBodyMode.Default, OnModeChanged));

        public OpenContentBodyMode Mode
        {
            get { return (OpenContentBodyMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        // Callback
        private static void OnTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as OpenContentBody;

            if (control == null)
                return;

            OpenContentBodyType newType = (OpenContentBodyType) e.NewValue;

            if (newType == OpenContentBodyType.Buyer)
            {
                // Show all button and counter
                control.OpenContentBody_Button1.Visibility = Visibility.Visible;
                control.OpenContentBody_Button1.Width = double.NaN;
                control.OpenContentBody_Button1.Margin = new Thickness(0, 0, 10, 0);

                control.OpenContentBody_Button2.Visibility = Visibility.Visible;
                control.OpenContentBody_Button2.Width = double.NaN;
                control.OpenContentBody_Button2.Margin = new Thickness(0, 0, 10, 0);

                control.OpenContentBody_Button3.Visibility = Visibility.Visible;
                control.OpenContentBody_Button3.Width = double.NaN;

                control.OpenContentBody_Counter.Visibility = Visibility.Visible;
                control.OpenContentBody_Counter.Width = double.NaN;
                control.OpenContentBody_Counter.Margin = new Thickness(0, 0, 10, 0);
            }
            else if (newType == OpenContentBodyType.Seller)
            {
                control.OpenContentBody_Seller.Visibility = Visibility.Collapsed;
                control.OpenContentBody_Stock.Visibility = Visibility.Collapsed;

                control.OpenContentBody_Button3.Visibility = Visibility.Visible;
                control.OpenContentBody_Button3.Width = double.NaN;
                control.OpenContentBody_Button3_Button.Content = "Hapus Jualan";
                control.OpenContentBody_Counter.Visibility = Visibility.Visible;
                control.OpenContentBody_Counter.Width = double.NaN;
                control.OpenContentBody_Counter.Margin = new Thickness(0, 0, 10, 0);

                control.OpenContentBody_EditTitleBorder.Visibility = Visibility.Visible;
                control.OpenContentBody_Title.Visibility = Visibility.Collapsed;

                control.OpenContentBody_EditDescBorder.Visibility = Visibility.Visible;
                control.OpenContentBody_Desc.Visibility = Visibility.Collapsed;

                control.OpenContentBody_EditPriceBorder.Visibility = Visibility.Visible;
                control.OpenContentBody_Price.Visibility = Visibility.Collapsed;
            }
            else if (newType == OpenContentBodyType.Reported)
            {
                control.OpenContentBody_Button1.Visibility = Visibility.Visible;
                control.OpenContentBody_Button1.Width = double.NaN;
                control.OpenContentBody_Button1.Background = Variables.ColorDarkGray;
                control.OpenContentBody_Button1.Margin = new Thickness(0, 0, 10, 0);
                control.OpenContentBody_Button1_Button.Content = "Tolak";

                control.OpenContentBody_Button2.Visibility = Visibility.Visible;
                control.OpenContentBody_Button2.Width = double.NaN;
                control.OpenContentBody_Button2.Background = Variables.ColorAccentOrange;
                control.OpenContentBody_Button2.Margin = new Thickness(0, 0, 10, 0);
                control.OpenContentBody_Button2_Button.Content = "Takedown";

                control.OpenContentBody_Button3.Visibility = Visibility.Visible;
                control.OpenContentBody_Button3.Width = double.NaN;
                control.OpenContentBody_Button3_Button.Content = "Ban User";

                control.OpenContentBody_ReportTab.Visibility = Visibility.Visible;
            }
            else if (newType == OpenContentBodyType.Banned)
            {
                control.OpenContentBody_Button3.Visibility = Visibility.Visible;
                control.OpenContentBody_Button3.Width = double.NaN;
                control.OpenContentBody_Button3_Button.Content = "Hapus Jualan";
                control.OpenContentBody_ReportTab_Title.Text = "Produk telah di-takedown:";

                control.OpenContentBody_ReportTab.Visibility = Visibility.Visible;
            }
        }

        private static void OnModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as OpenContentBody;

            if (control == null)
                return;

            OpenContentBodyMode newMode = (OpenContentBodyMode)e.NewValue;

            if (newMode == OpenContentBodyMode.Product)
            {
                control.OpenContentBody_ModeProduct.Visibility = Visibility.Visible;
            } else if (newMode == OpenContentBodyMode.Post)
            {
                control.OpenContentBody_ModePost.Visibility = Visibility.Visible;
                control.OpenContentBody_BorderParent.Height = double.NaN;
            }
        }
    }
}