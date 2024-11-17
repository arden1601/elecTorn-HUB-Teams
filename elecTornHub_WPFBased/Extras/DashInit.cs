using System.Windows;
using static elecTornHub_WPFBased.Components.Navbar;
using System.Windows.Data;
using System.Windows.Controls;
using elecTornHub_WPFBased.Pages;
using elecTornHub_WPFBased.Components;
using elecTornHub_WPFBased.ViewModels;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace elecTornHub_WPFBased.Extras
{
    public class DashInit
    {
        public static void GenerateNavbar(Grid NavbarControl, Enumerations.Navbar.NavbarType navbarType = Enumerations.Navbar.NavbarType.Default, Enumerations.Navbar.NavbarChosen navbarChosen = Enumerations.Navbar.NavbarChosen.Default, SearchDash parentSearch = null, OpenContent parentContent = null, SearchDash previousWindow = null)
        {
            NavbarControl.Children.Clear();
            var navbar = new Navbar { 
                NavbarType = navbarType,
                NavbarChosen = navbarChosen,
                ParentDash = parentSearch,
                ParentContent = parentContent,
                PreviousPage = previousWindow
            };

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

        public static void GenerateChoiceCards(CustomGrid CardGrids, Enumerations.ChoiceCard.ChoiceCardType GridType, Enumerations.CustomGrid.CustomGridMode GridMode, SearchDash parent, int count)
        {
            // Use StackPanel for a simpler vertical layout in a scrollable container
            CardGrids.Children.Clear();
            var stackPanel = new StackPanel { Orientation = Orientation.Vertical };

            int columnCount = 2;
            for (int i = 0; i < Math.Ceiling((double)count / columnCount); i++) // Adjust for incomplete rows
            {
                var rowGrid = new Grid();

                // Define column structure for each row
                for (int j = 0; j < columnCount && i * columnCount + j <= count; j++)
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

                    // DataContext Import from DB
                    ContentViewModel selectedContext = null;

                    if (GridType == Enumerations.ChoiceCard.ChoiceCardType.Post)
                    {
                        string imgSrc = "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo";
                        selectedContext = new ContentViewModel(
                            title: "Adakah kamu di situ?",
                            content: "Lorem ipsum odor amet, consectetuer adipiscing elit. Sapien scelerisque per conubia volutpat viverra tempus! Inceptos curae mi fusce proin senectus, condimentum volutpat dictum? Et risus rutrum habitasse cursus curae, accumsan integer aliquet. Suspendisse velit vel luctus id iaculis nisi. Duis platea ac consequat; blandit luctus elit. Sem maecenas primis himenaeos class fusce congue mauris nisi. Inceptos dui mollis ultricies donec congue laoreet sagittis purus.\r\n\r\nPurus habitant cras semper in est semper scelerisque. Magna aenean facilisi congue magna senectus amet? Sit tellus quisque viverra; sodales odio nulla. Venenatis magnis feugiat a ipsum tellus pulvinar. Nulla natoque sagittis quisque felis faucibus! Quisque at quam sociosqu integer libero. Vivamus morbi sapien ad et ante gravida conubia sollicitudin gravida.\r\n\r\nLorem ipsum odor amet, consectetuer adipiscing elit. Sapien scelerisque per conubia volutpat viverra tempus! Inceptos curae mi fusce proin senectus, condimentum volutpat dictum? Et risus rutrum habitasse cursus curae, accumsan integer aliquet. Suspendisse velit vel luctus id iaculis nisi. Duis platea ac consequat; blandit luctus elit. Sem maecenas primis himenaeos class fusce congue mauris nisi. Inceptos dui mollis ultricies donec congue laoreet sagittis purus.\r\n\r\nLorem ipsum odor amet, consectetuer adipiscing elit. Sapien scelerisque per conubia volutpat viverra tempus! Inceptos curae mi fusce proin senectus, condimentum volutpat dictum? Et risus rutrum habitasse cursus curae, accumsan integer aliquet. Suspendisse velit vel luctus id iaculis nisi. Duis platea ac consequat; blandit luctus elit. Sem maecenas primis himenaeos class fusce congue mauris nisi. Inceptos dui mollis ultricies donec congue laoreet sagittis purus.",
                            postDate: "16 September 2024",
                            lastEdit: "13 September 2024",
                            imgSrc: imgSrc
                        );
                        choiceCard.DataContext = selectedContext;
                    }
                    else if (GridType == Enumerations.ChoiceCard.ChoiceCardType.Product)
                    {
                        string imgSrc = "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn";
                        selectedContext = new ContentViewModel(
                            title: "Laptop ACER Intel Core",
                            description: "Laptop ini merupakan laptop kesayangan saya, tapi laptop ini terlalu bagus untuk saya sehingga saya memutuskan untuk menjualnya. Spesifikasi masih bagus, dijual murah karena kebetulan lagi butuh uang untuk memenuhi kebutuhan anak dan istri. Bagi siapapun yang berniat membantu saya, mohon beli produk ini. Jika Anda tidak mau membeli padahal sudah membaca sampai sini, saya akan gunakan IP Address Anda untuk melacak posisi Anda dan mengejar Anda sampai ke pelaminan. Sekian terima kasih, terima lah lagu ini dari orang biasa. Mohon maaf jika ada salah kata, akhir kata saya mengucapkan minta maaf. Sampai jumpa dalam LAPTOP ACER INTEL 2025! Wassalamu’alaikum warahmatullahi wabarakatuh. Laptop ini merupakan laptop kesayangan saya, tapi laptop ini terlalu bagus untuk saya sehingga saya memutuskan untuk menjualnya. Spesifikasi masih bagus, dijual murah karena kebetulan lagi butuh uang untuk memenuhi kebutuhan anak dan istri. Bagi siapapun yang berniat membantu saya, mohon beli produk ini. Jika Anda tidak mau membeli padahal sudah membaca sampai sini, saya akan gunakan IP Address Anda untuk melacak posisi Anda dan mengejar Anda sampai ke pelaminan. Sekian terima kasih, terima lah lagu ini dari orang biasa. Mohon maaf jika ada salah kata, akhir kata saya mengucapkan minta maaf. Sampai jumpa dalam LAPTOP ACER INTEL 2025! Wassalamu’alaikum warahmatullahi wabarakatuh.",
                            quantity: 1,
                            price: 696969,
                            imgSrc: imgSrc
                        );
                        choiceCard.DataContext = selectedContext;
                    }

                    // onClick action based on card type
                    if (GridType == Enumerations.ChoiceCard.ChoiceCardType.Product)
                    {
                        choiceCard.ProductCard_Button.Click += (s, e) =>
                        {
                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                NavbarType = Enumerations.Navbar.NavbarType.User,
                                dataContext = selectedContext
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
                            var newContent = new OpenContent
                            {
                                PreviousWindow = parent,
                                ContentType = Enumerations.OpenContent.OpenContentBodyType.Buyer,
                                ContentMode = Enumerations.OpenContent.OpenContentBodyMode.Post,
                                NavbarChosen = Enumerations.Navbar.NavbarChosen.Post,
                                NavbarType = Enumerations.Navbar.NavbarType.User,
                                dataContext = selectedContext
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

        public static void GenerateContent(Grid parentGrid, Enumerations.OpenContent.OpenContentBodyType ContentType, Enumerations.OpenContent.OpenContentBodyMode ContentMode, Enumerations.PostContent.PostContentType PostType, ContentViewModel DataContext)
        {
            parentGrid.Children.Clear();
            var content = new OpenContentBody
            {
                ContentType = ContentType,
                ContentMode = ContentMode,
                DataContext = DataContext
            };

            content.OpenContentBody_PostBody.Children.Clear();

            var postContent = new PostContent
            {
                PostType = PostType,
                DataContext = DataContext
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
