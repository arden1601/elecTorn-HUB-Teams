using System.ComponentModel; // Add this for INotifyPropertyChanged
using System.Windows;
using System.Windows.Controls;
using static elecTornHub_WPFBased.Extras.Variables;
using elecTornHub_WPFBased.Components;
using System.Windows.Data;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.Extras;
using static elecTornHub_WPFBased.Extras.Enumerations;
using elecTornHub_WPFBased.ViewModels;

namespace elecTornHub_WPFBased.Pages
{
    public partial class SearchDash : Window, Interfaces.INavbarParent, Interfaces.IContentCard
    {
        private ContentViewModel[] TemporaryPosts = new ContentViewModel[]
        {
            new ContentViewModel(
                postId: "1",
                author: new Classes.User(
                username: "Cornelius Joko",
                password: "johnjohnson123",
                uuid: "5"
            ),
                title: "Adakah kamu di situ?",
                content: "Lorem ipsum odor amet, consectetuer adipiscing elit. Sapien scelerisque per conubia volutpat viverra tempus! Inceptos curae mi fusce proin senectus, condimentum volutpat dictum? Et risus rutrum habitasse cursus curae, accumsan integer aliquet. Suspendisse velit vel luctus id iaculis nisi. Duis platea ac consequat; blandit luctus elit. Sem maecenas primis himenaeos class fusce congue mauris nisi. Inceptos dui mollis ultricies donec congue laoreet sagittis purus.",
                postDate: "16 September 2024",
                lastEdit: "13 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new CommentViewModel[]
                {
                    new CommentViewModel(
                        author: new Classes.User(
                            username: "John Doe",
                            password: "johndoe123",
                            uuid: "1"
                        ),
                        postId: "1",
                        content: "Berjuanglah meski sulit.",
                        postDate: "22 September 2024"
                    ),
                    new CommentViewModel(
                        author: new Classes.User(
                            username: "Jane Doe",
                            password: "janedoe123",
                            uuid: "2"
                        ),
                        postId: "2",
                        content: "Langkah pertama adalah yang paling sulit.",
                        postDate: "29 September 2024"
                    ),
                    new CommentViewModel(
                        author: new Classes.User(
                            username: "John Smith",
                            password: "johnsmith123",
                            uuid: "3"
                        ),
                        postId: "3",
                        content: "Semua kenangan akan tetap abadi.",
                        postDate: "5 October 2024"
                    )
                }
            ),
            new ContentViewModel(
                postId: "2",
                title: "Mimpi Semu",
                content: "Nulla accumsan, metus ultrices eleifend gravida, nulla nunc varius lectus, nec rutrum justo nibh eu lectus.",
                postDate: "22 September 2024",
                lastEdit: "20 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                author: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                comments: new CommentViewModel[]
                {
                    new CommentViewModel(
                        author:
                        new Classes.User(
                            username: "John Doe",
                            password: "johndoe123",
                            uuid: "1"
                        ),
                        postId: "4",
                        content: "Langkah pertama adalah yang paling sulit.",
                        postDate: "29 September 2024"
                    ),
                    new CommentViewModel(
                        author:
                        new Classes.User(
                            username: "Jane Doe",
                            password: "janedoe123",
                            uuid: "2"
                        ),
                        postId: "5",
                        content: "Semua kenangan akan tetap abadi.",
                        postDate: "5 October 2024"
                    )
                }
            ),
            new ContentViewModel(
                postId: "3",
                author:
                new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                ),
                title: "Perjalanan Tak Berujung",
                content: "Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.",
                postDate: "29 September 2024",
                lastEdit: "25 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new CommentViewModel[]
                {
                    new CommentViewModel(
                        author: 
                        new Classes.User(
                            username: "Jane Doe",
                            password: "janedoe123",
                            uuid: "2"
                        ),
                        postId: "6",
                        content: "Berjuanglah meski sulit.",
                        postDate: "22 September 2024"
                    )
                }
            ),
            new ContentViewModel(
                postId: "4",
                author:
                new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                ),
                title: "Kenangan yang Tersisa",
                content: "Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.",
                postDate: "5 October 2024",
                lastEdit: "2 October 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: []
            )
        };

        private ContentViewModel[] TemporaryProducts = new ContentViewModel[]
        {
            new ContentViewModel(
                price: 1000000,
                quantity: 10,
                productId: "1",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Laptop Asus ROG Strix G531GT",
                description: "Laptop gaming terbaik dengan spesifikasi tinggi. Dijual dengan harga terjangkau, jangan lewatkan kesempatan ini!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            ),
            new ContentViewModel(
                price: 265765,
                quantity: 5,
                productId: "2",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Smartphone Samsung Galaxy S20",
                description: "Ponsel flagship dengan spesifikasi terbaik. Dijual dengan harga terjangkau, jangan lewatkan kesempatan ini!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            ),
            new ContentViewModel(
                price: 1000000,
                quantity: 1,
                productId: "3",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Smartwatch Apple Watch Series 6",
                description: "Smartwatch terbaik dari Apple, dengan fitur terbaru dan desain yang elegan. Dijual dengan harga terjangkau!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            )
            
        };

        private ContentViewModel[] TemporarySellingProducts = new ContentViewModel[]
        {
            new ContentViewModel(
                price: 1000000,
                quantity: 10,
                productId: "1",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Laptop Asus ROG Strix G531GT",
                description: "Laptop gaming terbaik dengan spesifikasi tinggi. Dijual dengan harga terjangkau, jangan lewatkan kesempatan ini!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            )
        };

        // Getter Setter for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public ContentViewModel[] TemporaryPostsMod
        {
            get { return TemporaryPosts; }
            set { TemporaryPosts = value; }
        }

        public ContentViewModel[] TemporaryProductsMod
        {
            get { return TemporaryProducts; }
            set { TemporaryProducts = value; }
        }

        public ContentViewModel[] TemporarySellingProductsMod
        {
            get { return TemporarySellingProducts; }
            set { TemporarySellingProducts = value; }
        }

        // Push One for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public void PushOne(ContentViewModel[] arr, ContentViewModel item)
        {
            ContentViewModel[] newArr = new ContentViewModel[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[arr.Length] = item;
            arr = newArr;
        }

        // Delete by id for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public void DeleteById(ContentViewModel[] arr, string id)
        {
            ContentViewModel[] newArr = new ContentViewModel[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Post != null && arr[i].Post.PostId != id)
                {
                    newArr[j] = arr[i];
                    j++;
                }
                else if (arr[i].Product != null && arr[i].Product.ProductId != id)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            arr = newArr;
        }

        // Update by id for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public void UpdateById(ContentViewModel[] arr, string id, ContentViewModel item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Post != null && arr[i].Post.PostId == id)
                {
                    arr[i] = item;
                }
                else if (arr[i].Product != null && arr[i].Product.ProductId == id)
                {
                    arr[i] = item;
                }
            }
        }

        // Get by id for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public ContentViewModel GetById(ContentViewModel[] arr, string id)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Post != null && arr[i].Post.PostId == id)
                {
                    return arr[i];
                }
                else if (arr[i].Product != null && arr[i].Product.ProductId == id)
                {
                    return arr[i];
                }
            }
            return null;
        }

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

        private ContentViewModel[] TemporaryPick()
        {
            if (ContentType == Enumerations.ChoiceCard.ChoiceCardType.Post)
            {
                return TemporaryPosts;
            }
            else if (ContentType == Enumerations.ChoiceCard.ChoiceCardType.Product)
            {
                if (ContentMode == Enumerations.CustomGrid.CustomGridMode.Beli)
                {
                    return TemporaryProducts;
                }
                else if (ContentMode == Enumerations.CustomGrid.CustomGridMode.Jual)
                {
                    return TemporarySellingProducts;
                }
            }
            return [];
        }

        public void RegenerateContents()
        {
            ContentViewModel[] Contents = TemporaryPick();
            DashInit.GenerateChoiceCards(CardGrids, GridType: ContentType, GridMode: ContentMode, parent: this, ContentData: Contents);
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
                ContentViewModel[] Contents = TemporaryPick();

                DashInit.GenerateNavbar(NavbarControl, navbarType: NavbarType, navbarChosen: NavbarChosen, parentSearch: this);
                DashInit.GenerateChoiceCards(CardGrids, GridType: ContentType, GridMode: ContentMode, parent: this, ContentData: Contents);
                DashInit.UpdateAddButtonVisibility(SearchDash_AddButton, GridType: ContentType, GridMode: ContentMode);
            };
        }
    }
}