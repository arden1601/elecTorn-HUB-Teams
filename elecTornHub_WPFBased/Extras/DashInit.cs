using System.Windows;
using static elecTornHub_WPFBased.Components.Navbar;
using System.Windows.Data;
using System.Windows.Controls;
using elecTornHub_WPFBased.Pages;
using elecTornHub_WPFBased.Components;
using elecTornHub_WPFBased.ViewModels;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using elecTornHub_WPFBased.Classes;
using Npgsql.PostgresTypes;

namespace elecTornHub_WPFBased.Extras
{
    public class DashInit
    {
        public static Navbar GenerateNavbar(Grid NavbarControl, Enumerations.Navbar.NavbarType navbarType = Enumerations.Navbar.NavbarType.Default, Enumerations.Navbar.NavbarChosen navbarChosen = Enumerations.Navbar.NavbarChosen.Default, SearchDash parentSearch = null, OpenContent parentContent = null, SearchDash previousWindow = null)
        {
            NavbarControl.Children.Clear();
            var navbarControlMod = new Navbar { 
                NavbarType = navbarType,
                NavbarChosen = navbarChosen,
                ParentDash = parentSearch,
                ParentContent = parentContent,
                PreviousPage = previousWindow
            };

            navbarControlMod.Navbar_Logout.Click += async (s, e) =>
            {
                // Perform logout action
                bool isLoggedOut = await ContentViewModel.ActiveAccount.Logout();

                if (isLoggedOut)
                {
                    // Create new Login Page
                    Login newLogin = new Login();
                    newLogin.Show();

                    // Check if parentSearch and its PreviousWindow are valid before calling Close
                    if (parentSearch != null && parentSearch.IsLoaded)
                    {
                        parentSearch.Close();
                    }

                    if (parentSearch?.PreviousWindow != null && parentSearch.PreviousWindow.IsLoaded)
                    {
                        parentSearch.PreviousWindow.Close();
                    }

                    // Check if parentContent and its PreviousWindow are valid before calling Close
                    if (parentContent != null && parentContent.IsLoaded)
                    {
                        parentContent.Close();
                    }

                    if (parentContent?.PreviousWindow != null && parentContent.PreviousWindow.IsLoaded)
                    {
                        parentContent.PreviousWindow.Close();
                    }

                    // Response
                    MessageBox.Show("Logged out successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to log out!");
                }
            };


            NavbarControl.Children.Add(navbarControlMod);
            return navbarControlMod;
        }

        public static void UpdateNavbar(Grid NavbarControl, Enumerations.Navbar.NavbarType NavbarType, Enumerations.Navbar.NavbarChosen NavbarChosen)
        {
            if (NavbarControl.Children.Count > 0 && NavbarControl.Children[0] is Navbar navbar)
            {
                navbar.NavbarType = NavbarType;
                navbar.NavbarChosen = NavbarChosen;
            }
        }

        public static void GenerateChoiceCards(CustomGrid CardGrids, Enumerations.ChoiceCard.ChoiceCardType GridType, Enumerations.CustomGrid.CustomGridMode GridMode, SearchDash parent, ContentViewModel[] ContentData)
        {
            int count = ContentData.Length;

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

                    // DataContext Import from DB
                    ContentViewModel selectedContext = ContentData[currentIndex];

                    var choiceCard = new ChoiceCard
                    {
                        Margin = new Thickness(j % 2 == 0 ? 0 : 10, 0, j % 2 == 0 ? 10 : 0, 10),
                        ContentType = GridType, // Set based on the dependency property
                        ContentMode = GridMode, // Bind GridMode directly from SearchDash
                        DataContext = selectedContext
                    };

                    // onClick action based on card type
                    if (GridType == Enumerations.ChoiceCard.ChoiceCardType.Product)
                    {
                        choiceCard.ProductCard_Button.Click += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                NavbarType = Enumerations.Navbar.NavbarType.User,
                                DataContext = selectedContext
                            };

                            if (GridMode == Enumerations.CustomGrid.CustomGridMode.Jual)
                            {
                                newContent.ContentType = Enumerations.OpenContent.OpenContentBodyType.Seller;
                                newContent.ContentMode = Enumerations.OpenContent.OpenContentBodyMode.Product;
                                newContent.NavbarChosen = Enumerations.Navbar.NavbarChosen.Jual;
                            } else if (GridMode == Enumerations.CustomGrid.CustomGridMode.Beli)
                            {
                                newContent.ContentType = Enumerations.OpenContent.OpenContentBodyType.Buyer;
                                newContent.ContentMode = Enumerations.OpenContent.OpenContentBodyMode.Product;
                                newContent.NavbarChosen = Enumerations.Navbar.NavbarChosen.Beli;
                            }

                            newContent.Show();
                            parent.Hide();

                        };
                    }
                    else if (GridType == Enumerations.ChoiceCard.ChoiceCardType.Post)
                    {
                        choiceCard.MouseLeftButtonUp += (s, e) =>
                        {
                            Enumerations.PostContent.PostContentType postType = Enumerations.PostContent.PostContentType.Default;

                            if (selectedContext.Post.AuthorId.UserUUID == ContentViewModel.ActiveAccount.UserUUID) postType = Enumerations.PostContent.PostContentType.Poster;

                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                ContentType = Enumerations.OpenContent.OpenContentBodyType.Buyer,
                                ContentMode = Enumerations.OpenContent.OpenContentBodyMode.Post,
                                PostType = postType,
                                NavbarChosen = Enumerations.Navbar.NavbarChosen.Post,
                                NavbarType = Enumerations.Navbar.NavbarType.User,
                                DataContext = selectedContext
                            };

                            newContent.Show();
                            parent.Hide();
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

        public static void GenerateContent(Grid parentGrid, Enumerations.OpenContent.OpenContentBodyType ContentType, Enumerations.OpenContent.OpenContentBodyMode ContentMode, Enumerations.PostContent.PostContentType PostType, ContentViewModel DataContext, OpenContent parentContent)
        {
            parentGrid.Children.Clear();
            var content = new OpenContentBody(
                parentContent: parentContent,
                contentType: ContentType,
                contentMode: ContentMode,
                dataContext: DataContext
            );

            content.OpenContentBody_PostBody.Children.Clear();

            var postContent = new PostContent
            {
                PostType = PostType,
                DataContext = DataContext
            };

            // Handle Post type
            switch (PostType)
            {
                case Enumerations.PostContent.PostContentType.Poster:
                    postContent.PostContent_TopButton.Click += (s, e) =>
                    {
                        Functions.ClickDataHandler(
                            DataContext: parentContent.DataContext,
                            callback: (viewModel) => {
                                if (viewModel.Post_Id == "")
                                {
                                    // Random id generator (not using Math)
                                    viewModel.Post_Id = new System.Random().Next(100000, 999999).ToString();

                                    ContentViewModel.TemporaryPostsMod = ContentViewModel.PushOne(
                                        arrIn: ContentViewModel.TemporaryPostsMod,
                                        item: viewModel
                                    );

                                    parentContent.NavbarControlMod.ReturnToPrevious();
                                }
                                else if (viewModel.Post_Id != null)
                                {
                                    string selectedId = viewModel.Post_Id;
                                    ContentViewModel.TemporaryPostsMod = ContentViewModel.UpdateById(
                                        arrIn: ContentViewModel.TemporaryPostsMod,
                                        id: selectedId,
                                        item: viewModel
                                    );

                                    parentContent.NavbarControlMod.ReturnToPrevious();
                                }
                                else
                                {
                                    MessageBox.Show("Post_Id is null or inaccessible.");
                                }
                            }
                        );
                    };

                    postContent.PostContent_TopButton_Delete.Click += (s, e) =>
                    {
                        Functions.ClickDataHandler(
                            DataContext: parentContent.DataContext,
                            callback: (viewModel) => {
                                if (viewModel.Post_Id != null)
                                {
                                    string selectedId = viewModel.Post_Id;
                                    ContentViewModel.TemporaryPostsMod = ContentViewModel.DeleteById(
                                        arrIn: ContentViewModel.TemporaryPostsMod,
                                        id: selectedId
                                    );

                                    parentContent.NavbarControlMod.ReturnToPrevious();
                                }
                                else
                                {
                                    MessageBox.Show("Post_Id is null or inaccessible.");
                                }
                            }
                        );
                    };

                    break;
                case Enumerations.PostContent.PostContentType.Takedown:
                    break;
                case Enumerations.PostContent.PostContentType.Reported:
                    break;
                default:
                    break;
            }

            content.OpenContentBody_PostBody.Children.Add(postContent);

            content.OpenContentBody_PostBody.UpdateLayout();

            parentGrid.Children.Add(content);
            parentGrid.UpdateLayout();
        }

        private static void PostContent_TopButton_Delete_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
