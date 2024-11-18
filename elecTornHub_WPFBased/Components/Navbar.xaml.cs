using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.Pages;
using elecTornHub_WPFBased.Extras;
using System.Diagnostics;

namespace elecTornHub_WPFBased.Components
{
    using elecTornHub_WPFBased.Extras;
    using System.Threading.Channels;

    public partial class Navbar : UserControl, Interfaces.INavbar
    {
        // Implementing INavbarParent interface
        private Enumerations.Navbar.NavbarType _navbarType;
        private Enumerations.Navbar.NavbarChosen _navbarChosen;

        public Enumerations.Navbar.NavbarType NavbarType
        {
            get { return _navbarType; }
            set { _navbarType = value; OnTypeChanged(value); }
        }

        public Enumerations.Navbar.NavbarChosen NavbarChosen
        {
            get { return _navbarChosen; }
            set { _navbarChosen = value; OnChosenChanged(value); }
        }

        // Create a previous page that could be a SearchDash or OpenContent
        private SearchDash previousPage = null;

        public SearchDash PreviousPage
        {
            get { return previousPage; }
            set { previousPage = value; }
        }

        private SearchDash parentDash;
        private OpenContent parentContent;

        public SearchDash ParentDash
        {
            get { return parentDash; }
            set { parentDash = value; }
        }

        public OpenContent ParentContent
        {
            get { return parentContent; }
            set { parentContent = value; }
        }

        // Function to re-open previous page or content by checking which one is not null
        private void ReturnToPrevious(Enumerations.Navbar.NavbarChosen navbarChosen, Enumerations.CustomGrid.CustomGridMode navbarMode, Enumerations.ChoiceCard.ChoiceCardType cardType)
        {
            previousPage.NavbarChosen = navbarChosen;
            previousPage.ContentType = cardType;
            previousPage.ContentMode = navbarMode;
            previousPage.RegenerateContents();

            parentContent.KillingParent = false;
            parentContent.Close();
            previousPage.Show();
        }

        public void ReturnToPrevious()
        {
            ReturnToPrevious(
                navbarChosen: NavbarChosen,
                navbarMode: previousPage.ContentMode,
                cardType: previousPage.ContentType
                );
        }

        private void onClickUserNavBeli(object sender, RoutedEventArgs e)
        {
            Enumerations.Navbar.NavbarChosen Chosen = Enumerations.Navbar.NavbarChosen.Beli;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.ContentType = Enumerations.ChoiceCard.ChoiceCardType.Product;
                parentDash.ContentMode = Enumerations.CustomGrid.CustomGridMode.Beli;
                parentDash.RegenerateContents();

                OnChosenChanged(Chosen);
            }
            // If parentContent not null
            else if (previousPage != null)
            {
                // Open back previous content
                ReturnToPrevious(
                    navbarChosen: Enumerations.Navbar.NavbarChosen.Beli,
                    cardType: Enumerations.ChoiceCard.ChoiceCardType.Product,
                    navbarMode: Enumerations.CustomGrid.CustomGridMode.Beli
                );
            }
        }

        private void onClickUserNavJual(object sender, RoutedEventArgs e)
        {
            Enumerations.Navbar.NavbarChosen Chosen = Enumerations.Navbar.NavbarChosen.Jual;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.ContentType = Enumerations.ChoiceCard.ChoiceCardType.Product;
                parentDash.ContentMode = Enumerations.CustomGrid.CustomGridMode.Jual;
                parentDash.RegenerateContents();

                OnChosenChanged(Chosen);
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                // Open back previous content
                ReturnToPrevious(
                    navbarChosen: Enumerations.Navbar.NavbarChosen.Jual,
                    cardType: Enumerations.ChoiceCard.ChoiceCardType.Product,
                    navbarMode: Enumerations.CustomGrid.CustomGridMode.Jual
                );
            }
        }

        private void onClickUserNavPost(object sender, RoutedEventArgs e)
        {
            Enumerations.Navbar.NavbarChosen Chosen = Enumerations.Navbar.NavbarChosen.Post;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.ContentType = Enumerations.ChoiceCard.ChoiceCardType.Post;
                parentDash.RegenerateContents();

                OnChosenChanged(Chosen);
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                // Open back previous content
                ReturnToPrevious(
                    navbarChosen: Enumerations.Navbar.NavbarChosen.Post,
                    cardType: Enumerations.ChoiceCard.ChoiceCardType.Post,
                    navbarMode: Enumerations.CustomGrid.CustomGridMode.Default
                );
            }
        }

        private void onClickAdminNavPost(object sender, RoutedEventArgs e)
        {
            Enumerations.Navbar.NavbarChosen Chosen = Enumerations.Navbar.NavbarChosen.Post;
            
            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.ContentType = Enumerations.ChoiceCard.ChoiceCardType.Post;
                parentDash.RegenerateContents();

                OnChosenChanged(Chosen);
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                // Open back previous content
                ReturnToPrevious(
                    navbarChosen: Enumerations.Navbar.NavbarChosen.Post,
                    cardType: Enumerations.ChoiceCard.ChoiceCardType.Post,
                    navbarMode: Enumerations.CustomGrid.CustomGridMode.Default
                );
            }
        }

        private void onClickAdminNavItem(object sender, RoutedEventArgs e)
        {
            Enumerations.Navbar.NavbarChosen Chosen = Enumerations.Navbar.NavbarChosen.Item;

            // If parentDash not null
            if (parentDash != null)
            {
                parentDash.ContentType = Enumerations.ChoiceCard.ChoiceCardType.Product;
                parentDash.RegenerateContents();

                OnChosenChanged(Chosen);
            }
            // If parentContent not null
            else if (parentContent != null)
            {
                // Open back previous content
                ReturnToPrevious(
                    navbarChosen: Enumerations.Navbar.NavbarChosen.Item,
                    cardType: Enumerations.ChoiceCard.ChoiceCardType.Product,
                    navbarMode: Enumerations.CustomGrid.CustomGridMode.Default
                );
            }
        }

        public Navbar()
        {
            InitializeComponent();
            UpdateLayout();
            DataContext = this; // Set DataContext to itself

            // Nav onClicks
            Navbar_UserNavBeli.Click += onClickUserNavBeli;
            Navbar_UserNavJual.Click += onClickUserNavJual;
            Navbar_UserNavPost.Click += onClickUserNavPost;
            Navbar_AdminNavPost.Click += onClickAdminNavPost;
            Navbar_AdminNavItem.Click += onClickAdminNavItem;
        }

        private void OnTypeChanged(Enumerations.Navbar.NavbarType newValue)
        {
            Navbar_UserNav.Visibility = Visibility.Collapsed;
            Navbar_AdminNav.Visibility = Visibility.Collapsed;

            switch (newValue)
            {
                case Enumerations.Navbar.NavbarType.User:
                    Navbar_UserNav.Visibility = Visibility.Visible;
                    break;
                case Enumerations.Navbar.NavbarType.Admin:
                    Navbar_AdminNav.Visibility = Visibility.Visible;
                    Navbar_Search.Width = 564;
                    break;
            }
        }

        private void OnChosenChanged(Enumerations.Navbar.NavbarChosen newValue)
        {
            // set all background to transparent
            System.Windows.Media.Brush brush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Transparent);
            Navbar_UserNavBeliBorder.Background = brush;
            Navbar_UserNavJualBorder.Background = brush;
            Navbar_UserNavPostBorder.Background = brush;
            Navbar_AdminNavPostBorder.Background = brush;
            Navbar_AdminNavItemBorder.Background = brush;

            // Apply selected color based on new value
            switch (newValue)
            {
                case Enumerations.Navbar.NavbarChosen.Beli:
                    Navbar_UserNavBeliBorder.Background = Variables.ColorLightGray;
                    break;
                case Enumerations.Navbar.NavbarChosen.Jual:
                    Navbar_UserNavJualBorder.Background = Variables.ColorLightGray;
                    break;
                case Enumerations.Navbar.NavbarChosen.Post:
                    if (NavbarType == Enumerations.Navbar.NavbarType.User)
                        Navbar_UserNavPostBorder.Background = Variables.ColorLightGray;
                    else if (NavbarType == Enumerations.Navbar.NavbarType.Admin)
                        Navbar_AdminNavPostBorder.Background = Variables.ColorLightGray;
                    break;
                case Enumerations.Navbar.NavbarChosen.Item:
                    Navbar_AdminNavItemBorder.Background = Variables.ColorLightGray;
                    break;
                default:
                    break;
            }
        }
    }
}
