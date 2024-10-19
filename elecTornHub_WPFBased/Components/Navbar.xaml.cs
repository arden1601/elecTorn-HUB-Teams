using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.Pages;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Components
{
    using elecTornHub_WPFBased.Extras;
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
            this.DataContext = this; // Set DataContext to itse
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(Navbar), new PropertyMetadata(string.Empty, OnTypeChanged));

        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        private static void OnTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Navbar;
            string newType = e.NewValue as string;

            control.Navbar_UserNav.Visibility = Visibility.Collapsed;
            control.Navbar_AdminNav.Visibility = Visibility.Collapsed;

            if (newType == "User")
            {
                control.Navbar_UserNav.Visibility = Visibility.Visible;
            }
            else if (newType == "Admin")
            {
                control.Navbar_AdminNav.Visibility = Visibility.Visible;
                control.Navbar_Search.Width = 564;
            }
        }

        // DependencyProperty for Chosen
        public static readonly DependencyProperty ChosenProperty =
            DependencyProperty.Register("Chosen", typeof(string), typeof(Navbar), new PropertyMetadata(string.Empty, OnChosenChanged));

        public string Chosen
        {
            get { return (string)GetValue(ChosenProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for ChosenProperty
        private static void OnChosenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Navbar;
            string newChosen = e.NewValue as string;

            if (newChosen == "Beli")
            {
                control.Navbar_UserNavBeliBorder.Background = Variables.ColorLightGray;
            } else if (newChosen == "Jual")
            {
                control.Navbar_UserNavJualBorder.Background = Variables.ColorLightGray;
            } else if (newChosen == "Post")
            {
                if (control.Type == "User")
                {
                    control.Navbar_UserNavPostBorder.Background = Variables.ColorLightGray;
                } else if (control.Type == "Admin")
                {
                    control.Navbar_AdminNavPostBorder.Background = Variables.ColorLightGray;
                }
            } else if (newChosen == "Item")
            {
                control.Navbar_AdminNavItemBorder.Background = Variables.ColorLightGray;
            }
        }
    }
}
