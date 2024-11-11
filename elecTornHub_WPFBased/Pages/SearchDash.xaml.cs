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

        private void GenerateNavbar()
        {
            NavbarControl.Children.Clear();
            var navbar = new Navbar();
            navbar.SetBinding(Navbar.TypeProperty, new Binding(nameof(NavbarType)) { Source = this });
            navbar.SetBinding(Navbar.ChosenProperty, new Binding(nameof(NavbarChosen)) { Source = this });
            navbar.ParentDash = this;

            NavbarControl.Children.Add(navbar);
        }

        public void RegenerateContents()
        {
            GenerateChoiceCards(10);
            UpdateAddButtonVisibility();
        }

        private void UpdateNavbar()
        {
            if (NavbarControl.Children.Count > 0 && NavbarControl.Children[0] is Navbar navbar)
            {
                navbar.Type = NavbarType;
                navbar.Chosen = NavbarChosen;
            }
        }

        public SearchDash()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (s, e) =>
            {
                GenerateNavbar();
                GenerateChoiceCards(10); // Generate choice cards based on the GridType dependency property
                UpdateAddButtonVisibility();
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
            searchDash.UpdateNavbar(); // Update the Navbar when the type changes
        }

        private static void OnNavbarChosenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchDash = (SearchDash)d;

            // Set the new values
            searchDash.NavbarChosen = (Navbar.NavbarChosen)e.NewValue;
            searchDash.UpdateNavbar(); // Update the Navbar when the chosen option changes
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
            // Use StackPanel for a simpler vertical layout in a scrollable container
            CardGrids.Children.Clear();
            var stackPanel = new StackPanel { Orientation = Orientation.Vertical };

            int columnCount = 2;
            for (int i = 0; i < Math.Ceiling((double)count / columnCount); i++) // Adjust for incomplete rows
            {
                var rowGrid = new Grid();

                // Define column structure for each row
                for (int j = 0; j < columnCount; j++)
                {
                    rowGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                    int currentIndex = i * columnCount + j;
                    if (currentIndex >= count) break; // Prevents adding extra cards if the count isn't a perfect multiple of columnCount

                    var choiceCard = new ChoiceCard
                    {
                        Margin = new Thickness(j % 2 == 0 ? 0 : 10, 0, j % 2 == 0 ? 10 : 0, 10),
                        Type = GridType, // Set based on the dependency property
                        GridMode = GridMode // Bind GridMode directly from SearchDash
                    };

                    // onClick action based on card type
                    if (GridType == ChoiceCard.ChoiceCardType.Product)
                    {
                        choiceCard.Card_PostMode_Button.Click += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = this,
                                // Mode = OpenContent.OpenContentMode.Product
                            };

                            newContent.Show();
                            Close();
                        };
                    }
                    else if (GridType == ChoiceCard.ChoiceCardType.Post)
                    {
                        choiceCard.MouseLeftButtonUp += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = this,
                                // Mode = OpenContent.OpenContentMode.Post
                            };

                            newContent.Show();
                            Close();
                        };
                    }

                    Grid.SetColumn(choiceCard, j);
                    rowGrid.Children.Add(choiceCard);
                }

                stackPanel.Children.Add(rowGrid);
            }

            // Add the StackPanel to the CustomGrid
            CardGrids.Children.Add(stackPanel);

            // Update layout after adding new elements
            CardGrids.UpdateLayout();
        }
    }
}
