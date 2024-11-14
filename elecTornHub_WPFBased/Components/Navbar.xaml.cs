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

        private SearchDash parentDash;

        public SearchDash ParentDash
        {
            get { return parentDash; }
            set { parentDash = value; }
        }

        private OpenContent parentContent;

        public OpenContent ParentContent
        {
            get { return parentContent; }
            set { parentContent = value; }
        }

        private void onClickUserNavBeli(object sender, RoutedEventArgs e)
        {
            Chosen = NavbarChosen.Beli;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.GridType = ChoiceCard.ChoiceCardType.Product;
                parentDash.GridMode = CustomGrid.CustomGridMode.Beli;
                parentDash.RegenerateContents();
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                parentContent.ContentType = OpenContentBody.OpenContentBodyType.Buyer;
                parentContent.ContentMode = OpenContentBody.OpenContentBodyMode.Product;
                parentContent.RegenerateContents();
            }
        }

        private void onClickUserNavJual(object sender, RoutedEventArgs e)
        {
            Chosen = NavbarChosen.Jual;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.GridType = ChoiceCard.ChoiceCardType.Product;
                parentDash.GridMode = CustomGrid.CustomGridMode.Jual;
                parentDash.RegenerateContents();
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                parentContent.ContentType = OpenContentBody.OpenContentBodyType.Seller;
                parentContent.ContentMode = OpenContentBody.OpenContentBodyMode.Product;
                parentContent.RegenerateContents();
            }
        }

        private void onClickUserNavPost(object sender, RoutedEventArgs e)
        {
            Chosen = NavbarChosen.Post;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.GridType = ChoiceCard.ChoiceCardType.Post;
                parentDash.RegenerateContents();
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                parentContent.ContentType = OpenContentBody.OpenContentBodyType.Buyer;
                parentContent.ContentMode = OpenContentBody.OpenContentBodyMode.Post;
                parentContent.RegenerateContents();
            }
        }

        private void onClickAdminNavPost(object sender, RoutedEventArgs e)
        {
            Chosen = NavbarChosen.Post;
            
            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.GridType = ChoiceCard.ChoiceCardType.Post;
                parentDash.RegenerateContents();
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                parentContent.ContentMode = OpenContentBody.OpenContentBodyMode.Post;
                parentContent.RegenerateContents();
            }
        }

        private void onClickAdminNavItem(object sender, RoutedEventArgs e)
        {
            Chosen = NavbarChosen.Item;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.GridType = ChoiceCard.ChoiceCardType.Product;
                parentDash.RegenerateContents();
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                parentContent.ContentMode = OpenContentBody.OpenContentBodyMode.Product;
                parentContent.RegenerateContents();
            }
        }

        public Navbar()
        {
            InitializeComponent();
            UpdateLayout();
            this.DataContext = this; // Set DataContext to itself

            // launch ontypechanged and onchosenchanged
            OnTypeChanged(this, new DependencyPropertyChangedEventArgs(TypeProperty, NavbarType.Default, NavbarType.User));
            OnChosenChanged(this, new DependencyPropertyChangedEventArgs(ChosenProperty, NavbarChosen.Default, NavbarChosen.Beli));

            // Nav onClicks
            Navbar_UserNavBeli.Click += onClickUserNavBeli;
            Navbar_UserNavJual.Click += onClickUserNavJual;
            Navbar_UserNavPost.Click += onClickUserNavPost;
            Navbar_AdminNavPost.Click += onClickAdminNavPost;
            Navbar_AdminNavItem.Click += onClickAdminNavItem;

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
            if (control == null) return;

            control.Navbar_UserNav.Visibility = Visibility.Collapsed;
            control.Navbar_AdminNav.Visibility = Visibility.Collapsed;

            switch ((NavbarType)e.NewValue)
            {
                case NavbarType.User:
                    control.Navbar_UserNav.Visibility = Visibility.Visible;
                    break;
                case NavbarType.Admin:
                    control.Navbar_AdminNav.Visibility = Visibility.Visible;
                    control.Navbar_Search.Width = 564;
                    break;
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
            if (control == null) return;

            // set all background to transparent
            System.Windows.Media.Brush brush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Transparent);
            control.Navbar_UserNavBeliBorder.Background = brush;
            control.Navbar_UserNavJualBorder.Background = brush;
            control.Navbar_UserNavPostBorder.Background = brush;
            control.Navbar_AdminNavPostBorder.Background = brush;
            control.Navbar_AdminNavItemBorder.Background = brush;

            // Apply selected color based on new value
            switch ((NavbarChosen)e.NewValue)
            {
                case NavbarChosen.Beli:
                    control.Navbar_UserNavBeliBorder.Background = Variables.ColorLightGray;

                    break;
                case NavbarChosen.Jual:
                    control.Navbar_UserNavJualBorder.Background = Variables.ColorLightGray;
                    break;
                case NavbarChosen.Post:
                    if (control.Type == NavbarType.User)
                        control.Navbar_UserNavPostBorder.Background = Variables.ColorLightGray;
                    else if (control.Type == NavbarType.Admin)
                        control.Navbar_AdminNavPostBorder.Background = Variables.ColorLightGray;
                    break;
                case NavbarChosen.Item:
                    control.Navbar_AdminNavItemBorder.Background = Variables.ColorLightGray;
                    break;
                default:
                    break;
            }
        }
    }
}
