using System.ComponentModel; // Add this for INotifyPropertyChanged
using System.Windows;
using System.Windows.Controls;
using static elecTornHub_WPFBased.Extras.Variables;
using elecTornHub_WPFBased.Components;
using System.Windows.Data;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Pages
{
    public partial class SearchDash : Window
    {
        public Window PreviousWindow { get; set; }

        // Define GridMode as a DependencyProperty
        public static readonly DependencyProperty GridModeProperty =
            DependencyProperty.Register(nameof(GridMode), typeof(CustomGrid.CustomGridMode), typeof(SearchDash),
                new PropertyMetadata(CustomGrid.CustomGridMode.Default, OnGridModeChanged));

        public CustomGrid.CustomGridMode GridMode
        {
            get => (CustomGrid.CustomGridMode)GetValue(GridModeProperty);
            set => SetValue(GridModeProperty, value);
        }

        // Define GridType as a DependencyProperty
        public static readonly DependencyProperty GridTypeProperty =
            DependencyProperty.Register(nameof(GridType), typeof(ChoiceCard.ChoiceCardType), typeof(SearchDash),
                new PropertyMetadata(ChoiceCard.ChoiceCardType.Product, OnGridTypeChanged));

        public ChoiceCard.ChoiceCardType GridType
        {
            get => (ChoiceCard.ChoiceCardType)GetValue(GridTypeProperty);
            set => SetValue(GridTypeProperty, value);
        }

        // Define NavbarType as a DependencyProperty
        public static readonly DependencyProperty NavbarTypeProperty =
            DependencyProperty.Register(nameof(NavbarType), typeof(Navbar.NavbarType), typeof(SearchDash),
                new PropertyMetadata(Navbar.NavbarType.Default, OnNavbarTypeChanged));

        public Navbar.NavbarType NavbarType
        {
            get => (Navbar.NavbarType)GetValue(NavbarTypeProperty);
            set => SetValue(NavbarTypeProperty, value);
        }

        // Define NavbarChosen as a DependencyProperty
        public static readonly DependencyProperty NavbarChosenProperty =
            DependencyProperty.Register(nameof(NavbarChosen), typeof(Navbar.NavbarChosen), typeof(SearchDash),
                new PropertyMetadata(Navbar.NavbarChosen.Default, OnNavbarChosenChanged));

        public Navbar.NavbarChosen NavbarChosen
        {
            get => (Navbar.NavbarChosen)GetValue(NavbarChosenProperty);
            set => SetValue(NavbarChosenProperty, value);
        }

        public void RegenerateContents()
        {
            DashInit.GenerateChoiceCards(CardGrids, GridType, GridMode, this, 10);
            DashInit.UpdateAddButtonVisibility(SearchDash_AddButton, GridMode, GridType);
        }

        public SearchDash()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (s, e) =>
            {
                DashInit.GenerateNavbar(NavbarControl, this);
                DashInit.GenerateChoiceCards(CardGrids, GridType, GridMode, this, 10);
                DashInit.UpdateAddButtonVisibility(SearchDash_AddButton, GridMode, GridType);
            };
        }

        private static void OnGridModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;
            searchDash.GridMode = (CustomGrid.CustomGridMode)e.NewValue;
        }


        // Updated to regenerate ChoiceCards when GridType changes
        private static void OnGridTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;
            searchDash.GridType = (ChoiceCard.ChoiceCardType)e.NewValue;
        }

        private static void OnNavbarTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;
            searchDash.NavbarType = (Navbar.NavbarType)e.NewValue;
            DashInit.UpdateNavbar(searchDash.NavbarControl, searchDash.NavbarType, searchDash.NavbarChosen);
        }

        private static void OnNavbarChosenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;

            // Set the new values
            searchDash.NavbarChosen = (Navbar.NavbarChosen)e.NewValue;
            DashInit.UpdateNavbar(searchDash.NavbarControl, searchDash.NavbarType, searchDash.NavbarChosen);
        }
    }
}
