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
        private readonly ContentViewModel[] TemporaryPosts = new ContentViewModel[]
        {
            new ContentViewModel(
                title: "Adakah kamu di situ?",
                content: "Lorem ipsum odor amet, consectetuer adipiscing elit. Sapien scelerisque per conubia volutpat viverra tempus! Inceptos curae mi fusce proin senectus, condimentum volutpat dictum? Et risus rutrum habitasse cursus curae, accumsan integer aliquet. Suspendisse velit vel luctus id iaculis nisi. Duis platea ac consequat; blandit luctus elit. Sem maecenas primis himenaeos class fusce congue mauris nisi. Inceptos dui mollis ultricies donec congue laoreet sagittis purus.",
                postDate: "16 September 2024",
                lastEdit: "13 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new Classes.Comment[]
                {
                    new Classes.Comment(
                        postId: "1",
                        authorId: new Classes.User(username: "Cornelius Joko", password: "lol", uuid: "lalala"),
                        content: "Ketika mimpimu yang begitu indah, tak pernah terwujud ya sudahlah.",
                        postDate: "6 September 969",
                        title: "",
                        destinationPostId: "1"
                    ),
                    new Classes.Comment(
                        postId: "2",
                        authorId: new Classes.User(username: "CorArden", password: "lol", uuid: "lalala"),
                        content: "Semangat mengejar dan tak pernah sampai, ya sudahlah.",
                        postDate: "6 September 969",
                        title: "",
                        destinationPostId: "1"
                    )
                }
            ),
            new ContentViewModel(
                title: "Mimpi Semu",
                content: "Nulla accumsan, metus ultrices eleifend gravida, nulla nunc varius lectus, nec rutrum justo nibh eu lectus.",
                postDate: "22 September 2024",
                lastEdit: "20 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new Classes.Comment[]
                {
                    new Classes.Comment(
                        postId: "3",
                        authorId: new Classes.User(username: "Rara Kirana", password: "test", uuid: "uuid123"),
                        content: "Berjuanglah meski sulit.",
                        postDate: "22 September 2024",
                        title: "",
                        destinationPostId: "2"
                    )
                }
            ),
            new ContentViewModel(
                title: "Perjalanan Tak Berujung",
                content: "Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.",
                postDate: "29 September 2024",
                lastEdit: "25 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new Classes.Comment[]
                {
                    new Classes.Comment(
                        postId: "4",
                        authorId: new Classes.User(username: "Nadia Putri", password: "password", uuid: "uuid456"),
                        content: "Langkah pertama adalah yang paling sulit.",
                        postDate: "29 September 2024",
                        title: "",
                        destinationPostId: "3"
                    )
                }
            ),
            new ContentViewModel(
                title: "Kenangan yang Tersisa",
                content: "Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.",
                postDate: "5 October 2024",
                lastEdit: "2 October 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new Classes.Comment[]
                {
                    new Classes.Comment(
                        postId: "5",
                        authorId: new Classes.User(username: "Ardi Setiawan", password: "simplepass", uuid: "uuid789"),
                        content: "Semua kenangan akan tetap abadi.",
                        postDate: "5 October 2024",
                        title: "",
                        destinationPostId: "4"
                    )
                }
            )
        };

        private readonly ContentViewModel[] TemporaryProducts = new ContentViewModel[]
        {
            new ContentViewModel(
                title: "Laptop ACER Intel Core",
                description: "Laptop ini merupakan laptop kesayangan saya, tapi laptop ini terlalu bagus untuk saya sehingga saya memutuskan untuk menjualnya...",
                quantity: 1,
                price: 696969,
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            ),
            new ContentViewModel(
                title: "Smartphone Samsung Galaxy S20",
                description: "Ponsel flagship dengan spesifikasi terbaik. Dijual dengan harga terjangkau, jangan lewatkan kesempatan ini!",
                quantity: 2,
                price: 1500000,
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            ),
            new ContentViewModel(
                title: "Headphone Bluetooth",
                description: "Headphone wireless berkualitas tinggi dengan suara yang jernih. Cocok untuk mendengarkan musik kapan saja.",
                quantity: 5,
                price: 250000,
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            )
        };


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

                return TemporaryProducts;
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
