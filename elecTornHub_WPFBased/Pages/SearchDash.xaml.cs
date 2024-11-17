using System.ComponentModel; // Add this for INotifyPropertyChanged
using System.Windows;
using System.Windows.Controls;
using static elecTornHub_WPFBased.Extras.Variables;
using elecTornHub_WPFBased.Components;
using System.Windows.Data;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.Extras;
using static elecTornHub_WPFBased.Extras.Enumerations;

namespace elecTornHub_WPFBased.Pages
{
    public partial class SearchDash : Window, Interfaces.INavbarParent, Interfaces.IContentCard
    {
        // Implement INavbarParent
        private Enumerations.Navbar.NavbarType _navbarType;

        public Enumerations.Navbar.NavbarType NavbarType
        {
            get { return _navbarType; }
            set { _navbarType = value; OnNavbarPropsChanged(); }
        }

        private Enumerations.Navbar.NavbarChosen _navbarChosen;

        public Enumerations.Navbar.NavbarChosen NavbarChosen
        {
            get { return _navbarChosen; }
            set { _navbarChosen = value; OnNavbarPropsChanged(); }
        }

        private void OnNavbarPropsChanged()
        {
            DashInit.UpdateNavbar(NavbarControl, NavbarType, NavbarChosen);
        }

        // Implement IContentCard
        private Enumerations.CustomGrid.CustomGridMode _contentMode;
        private Enumerations.ChoiceCard.ChoiceCardType _contentType;

        public Enumerations.CustomGrid.CustomGridMode ContentMode
        {
            get { return _contentMode; }
            set { _contentMode = value; }
        }

        public Enumerations.ChoiceCard.ChoiceCardType ContentType
        {
            get { return _contentType; }
            set { _contentType = value; }
        }

        public Window PreviousWindow { get; set; }

        public void RegenerateContents()
        {
            DashInit.GenerateChoiceCards(CardGrids, GridType: ContentType, GridMode: ContentMode, parent: this, count: 10);
            DashInit.UpdateAddButtonVisibility(SearchDash_AddButton, GridType: ContentType, GridMode: ContentMode);
        }

        public SearchDash()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (s, e) =>
            {
                // Setting properties manually instead of using XAML Binding
                CardGrids.ContentMode = ContentMode;
                CardGrids.ContentType = ContentType;

                DashInit.GenerateNavbar(NavbarControl, navbarType: NavbarType, navbarChosen: NavbarChosen, parentSearch: this);
                DashInit.GenerateChoiceCards(CardGrids, GridType: ContentType, GridMode: ContentMode, parent: this, count: 10);
                DashInit.UpdateAddButtonVisibility(SearchDash_AddButton, GridType: ContentType, GridMode: ContentMode);
            };
        }
    }
}
