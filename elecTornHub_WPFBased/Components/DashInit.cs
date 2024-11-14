using System.Windows;
using static elecTornHub_WPFBased.Components.Navbar;
using System.Windows.Data;
using System.Windows.Controls;
using elecTornHub_WPFBased.Pages;

namespace elecTornHub_WPFBased.Components
{
    public class DashInit
    {
        public static void GenerateNavbar(Grid NavbarControl, SearchDash parentSearch = null)
        {
            NavbarControl.Children.Clear();
            var navbar = new Navbar();
            
            if (parentSearch != null)
            {
                navbar.SetBinding(TypeProperty, new Binding(nameof(NavbarType)) { Source = parentSearch });
                navbar.SetBinding(ChosenProperty, new Binding(nameof(NavbarChosen)) { Source = parentSearch });
                navbar.ParentDash = parentSearch;
            }

            NavbarControl.Children.Add(navbar);
        }

        public static void GenerateNavbar(Grid NavbarControl, OpenContent parentSearch = null)
        {
            NavbarControl.Children.Clear();
            var navbar = new Navbar();

            if (parentSearch != null)
            {
                navbar.SetBinding(TypeProperty, new Binding(nameof(NavbarType)) { Source = parentSearch });
                navbar.SetBinding(ChosenProperty, new Binding(nameof(NavbarChosen)) { Source = parentSearch });
                navbar.ParentContent = parentSearch;
            }

            NavbarControl.Children.Add(navbar);
        }

        public static void UpdateNavbar(Grid NavbarControl, NavbarType NavbarType, NavbarChosen NavbarChosen)
        {
            if (NavbarControl.Children.Count > 0 && NavbarControl.Children[0] is Navbar navbar)
            {
                navbar.Type = NavbarType;
                navbar.Chosen = NavbarChosen;
            }
        }

        public static void GenerateChoiceCards(CustomGrid CardGrids, ChoiceCard.ChoiceCardType GridType, CustomGrid.CustomGridMode GridMode, Window parent, int count)
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

                    // Set the DataContext to the current instance of SearchDash
                    choiceCard.DataContext = parent;

                    // onClick action based on card type
                    if (GridType == ChoiceCard.ChoiceCardType.Product)
                    {
                        choiceCard.ProductCard_Button.Click += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                ContentType = OpenContentBody.OpenContentBodyType.Buyer,
                                ContentMode = OpenContentBody.OpenContentBodyMode.Product,
                                NavbarChosen = NavbarChosen.Beli,
                                NavbarType = NavbarType.User
                            };

                            newContent.Show();
                            parent.Close();

                        };
                    }
                    else if (GridType == ChoiceCard.ChoiceCardType.Post)
                    {
                        choiceCard.MouseLeftButtonUp += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                ContentType = OpenContentBody.OpenContentBodyType.Buyer,
                                ContentMode = OpenContentBody.OpenContentBodyMode.Post,
                                NavbarChosen = NavbarChosen.Post,
                                NavbarType = NavbarType.User
                            };

                            newContent.Show();
                            parent.Close();
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

        public static void GenerateContent(Grid parentGrid, OpenContentBody.OpenContentBodyType ContentType, OpenContentBody.OpenContentBodyMode ContentMode, PostContent.PostContentType PostType)
        {
            parentGrid.Children.Clear();
            var content = new OpenContentBody
            {
                Type = ContentType,
                Mode = ContentMode
            };

            content.OpenContentBody_PostBody.Children.Clear();

            var postContent = new PostContent
            {
                Type = PostType
            };

            content.OpenContentBody_PostBody.Children.Add(postContent);

            content.OpenContentBody_PostBody.UpdateLayout();

            parentGrid.Children.Add(content);
            parentGrid.UpdateLayout();
        }

        public static void UpdateAddButtonVisibility(Border SearchDash_AddButton, CustomGrid.CustomGridMode GridMode, ChoiceCard.ChoiceCardType GridType)
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
    }
}
