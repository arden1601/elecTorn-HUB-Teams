﻿using System.Windows;
using static elecTornHub_WPFBased.Components.Navbar;
using System.Windows.Data;
using System.Windows.Controls;
using elecTornHub_WPFBased.Pages;
using elecTornHub_WPFBased.Components;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Extras
{
    public class DashInit
    {
        public static void GenerateNavbar(Grid NavbarControl, Enumerations.Navbar.NavbarType navbarType = Enumerations.Navbar.NavbarType.Default, Enumerations.Navbar.NavbarChosen navbarChosen = Enumerations.Navbar.NavbarChosen.Default, SearchDash parentSearch = null, OpenContent parentContent = null)
        {
            NavbarControl.Children.Clear();
            var navbar = new Navbar { 
                NavbarType = navbarType,
                NavbarChosen = navbarChosen
            };

            if (parentSearch != null)
            {
                navbar.ParentDash = parentSearch;
            }
            else if (parentContent != null)
            {
                navbar.ParentContent = parentContent;
            }

            NavbarControl.Children.Add(navbar);
        }

        public static void UpdateNavbar(Grid NavbarControl, Enumerations.Navbar.NavbarType NavbarType, Enumerations.Navbar.NavbarChosen NavbarChosen)
        {
            if (NavbarControl.Children.Count > 0 && NavbarControl.Children[0] is Navbar navbar)
            {
                navbar.NavbarType = NavbarType;
                navbar.NavbarChosen = NavbarChosen;
            }
        }

        public static void GenerateChoiceCards(CustomGrid CardGrids, Enumerations.ChoiceCard.ChoiceCardType GridType, Enumerations.CustomGrid.CustomGridMode GridMode, Window parent, int count)
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
                        ContentType = GridType, // Set based on the dependency property
                        ContentMode = GridMode // Bind GridMode directly from SearchDash
                    };

                    // Set the DataContext to the current instance of SearchDash
                    choiceCard.DataContext = parent;

                    // onClick action based on card type
                    if (GridType == Enumerations.ChoiceCard.ChoiceCardType.Product)
                    {
                        choiceCard.ProductCard_Button.Click += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                ContentType = Enumerations.OpenContent.OpenContentBodyType.Buyer,
                                ContentMode = Enumerations.OpenContent.OpenContentBodyMode.Product,
                                NavbarChosen = Enumerations.Navbar.NavbarChosen.Beli,
                                NavbarType = Enumerations.Navbar.NavbarType.User
                            };

                            newContent.Show();
                            parent.Close();

                        };
                    }
                    else if (GridType == Enumerations.ChoiceCard.ChoiceCardType.Post)
                    {
                        choiceCard.MouseLeftButtonUp += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                ContentType = Enumerations.OpenContent.OpenContentBodyType.Buyer,
                                ContentMode = Enumerations.OpenContent.OpenContentBodyMode.Post,
                                NavbarChosen = Enumerations.Navbar.NavbarChosen.Post,
                                NavbarType = Enumerations.Navbar.NavbarType.User
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

        public static void GenerateContent(Grid parentGrid, Enumerations.OpenContent.OpenContentBodyType ContentType, Enumerations.OpenContent.OpenContentBodyMode ContentMode, Enumerations.PostContent.PostContentType PostType)
        {
            parentGrid.Children.Clear();
            var content = new OpenContentBody
            {
                ContentType = ContentType,
                ContentMode = ContentMode
            };

            content.OpenContentBody_PostBody.Children.Clear();

            var postContent = new PostContent
            {
                PostType = PostType
            };

            content.OpenContentBody_PostBody.Children.Add(postContent);

            content.OpenContentBody_PostBody.UpdateLayout();

            parentGrid.Children.Add(content);
            parentGrid.UpdateLayout();
        }

        public static void UpdateAddButtonVisibility(Border SearchDash_AddButton, Enumerations.CustomGrid.CustomGridMode GridMode, Enumerations.ChoiceCard.ChoiceCardType GridType)
        {
            if (GridMode == Enumerations.CustomGrid.CustomGridMode.Jual ||
                GridType == Enumerations.ChoiceCard.ChoiceCardType.Post && GridMode == Enumerations.CustomGrid.CustomGridMode.Jual)
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