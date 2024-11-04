using System.ComponentModel; // Add this for INotifyPropertyChanged
using System.Windows;
using System.Windows.Controls;
using static elecTornHub_WPFBased.Extras.Variables;
using elecTornHub_WPFBased.Components;

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

        public SearchDash()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (s, e) =>
            {
                GenerateChoiceCards(100);
                UpdateAddButtonVisibility();
            };
        }

        private static void OnGridModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;
            searchDash.UpdateAddButtonVisibility();
            searchDash.UpdateCardButtonContent((CustomGrid.CustomGridMode)e.NewValue);
        }

        private static void OnGridTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;
            searchDash.UpdateAddButtonVisibility();
        }

        private static void OnNavbarTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;
            searchDash.NavbarType = (Navbar.NavbarType)e.NewValue;
        }

        private static void OnNavbarChosenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;
            searchDash.NavbarChosen = (Navbar.NavbarChosen)e.NewValue;
        }

        // Update AddButton Visibility based on CustomGrid Mode and Type
        private void UpdateAddButtonVisibility()
        {
            if (GridMode == CustomGrid.CustomGridMode.Jual ||
                (GridType == ChoiceCard.ChoiceCardType.Post && GridMode == CustomGrid.CustomGridMode.Jual))
            {
                SearchDash_AddButton.Visibility = Visibility.Visible;
            }
            else
            {
                SearchDash_AddButton.Visibility = Visibility.Collapsed;
            }
        }

        // Generate choice cards and set their properties based on dependency properties
        private void GenerateChoiceCards(int count)
        {
            // Use StackPanel for simpler vertical layout in a scrollable container
            CardGrids.Children.Clear();
            var stackPanel = new StackPanel { Orientation = Orientation.Vertical };

            int columnCount = 2;
            for (int i = 0; i < count / columnCount; i++)
            {
                var rowGrid = new Grid();

                // Define column structure for each row
                for (int j = 0; j < columnCount; j++)
                {
                    rowGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                    var choiceCard = new ChoiceCard
                    {
                        Margin = new Thickness(j % 2 == 0 ? 0 : 10, 0, j % 2 == 0 ? 10 : 0, 10),
                        Type = GridType // Set based on the dependency property
                    };

                    Grid.SetColumn(choiceCard, j);
                    rowGrid.Children.Add(choiceCard);
                }

                stackPanel.Children.Add(rowGrid);
            }

            // Add the StackPanel to the CustomGrid
            CardGrids.Children.Add(stackPanel);

            // Update button content based on the GridMode
            UpdateCardButtonContent(GridMode);
        }


        private void UpdateCardButtonContent(CustomGrid.CustomGridMode mode)
        {
            foreach (var child in CardGrids.Children)
            {
                if (child is ChoiceCard choiceCard)
                {
                    choiceCard.ProductCard_Button.Content = mode switch
                    {
                        CustomGrid.CustomGridMode.Beli => "Beli Sekarang",
                        CustomGrid.CustomGridMode.Jual => "Edit",
                        CustomGrid.CustomGridMode.Admin => "Periksa",
                        _ => choiceCard.ProductCard_Button.Content
                    };
                }
            }
        }
    }
}
