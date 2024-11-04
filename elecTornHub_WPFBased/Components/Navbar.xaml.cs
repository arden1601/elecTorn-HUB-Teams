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
        public enum NavbarType
        {
            Default,
            User,
            Admin
        }

        public enum NavbarChosen
        {
            Default,
            Beli,
            Jual,
            Post,
            Item
        }

        public Navbar()
        {
            InitializeComponent();
            UpdateLayout();
            this.DataContext = this; // Set DataContext to itse
            /*this.Navbar_AdminNav.Visibility = Visibility.Collapsed;
            this.Navbar_UserNav.Visibility = Visibility.Collapsed;*/
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(NavbarType), typeof(Navbar), new PropertyMetadata(NavbarType.User, OnTypeChanged));

        public NavbarType Type
        {
            get { return (NavbarType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        private static void OnTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Navbar;

            if (control == null)
                return;

            NavbarType newType = (NavbarType)e.NewValue;

            if (newType == NavbarType.User)
            {
                control.Navbar_UserNav.Visibility = Visibility.Visible;
            }
            else if (newType == NavbarType.Admin)
            {
                control.Navbar_AdminNav.Visibility = Visibility.Visible;
                control.Navbar_Search.Width = 564;
            }
        }

        // DependencyProperty for Chosen
        public static readonly DependencyProperty ChosenProperty =
            DependencyProperty.Register("Chosen", typeof(NavbarChosen), typeof(Navbar), new PropertyMetadata(NavbarChosen.Beli, OnChosenChanged));

        public NavbarChosen Chosen
        {
            get { return (NavbarChosen)GetValue(ChosenProperty); }
            set { SetValue(ChosenProperty, value); }
        }

        // Callback method for ChosenProperty
        private static void OnChosenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Navbar;

            if (control == null)
                return;

            NavbarChosen newChosen = (NavbarChosen)e.NewValue;

            if (newChosen == NavbarChosen.Beli)
            {
                control.Navbar_UserNavBeliBorder.Background = Variables.ColorLightGray;
            }
            else if (newChosen == NavbarChosen.Jual)
            {
                control.Navbar_UserNavJualBorder.Background = Variables.ColorLightGray;
            }
            else if (newChosen == NavbarChosen.Post)
            {
                if (control.Type == NavbarType.User)
                {
                    control.Navbar_UserNavPostBorder.Background = Variables.ColorLightGray;
                }
                else if (control.Type == NavbarType.Admin)
                {
                    control.Navbar_AdminNavPostBorder.Background = Variables.ColorLightGray;
                }
            }
            else if (newChosen == NavbarChosen.Item)
            {
                control.Navbar_AdminNavItemBorder.Background = Variables.ColorLightGray;
            }
        }
    }
}
