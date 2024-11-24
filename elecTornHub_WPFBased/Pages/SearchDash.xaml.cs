using System.ComponentModel; // Add this for INotifyPropertyChanged
using System.Windows;
using System.Windows.Controls;
using static elecTornHub_WPFBased.Extras.Variables;
using elecTornHub_WPFBased.Classes;
using System.Windows.Data;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.Extras;
using static elecTornHub_WPFBased.Extras.Enumerations;
using elecTornHub_WPFBased.ViewModels;

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

        private Components.Navbar _navbar = null;

        private Enumerations.Navbar.NavbarChosen _navbarChosen;

        public Enumerations.Navbar.NavbarChosen NavbarChosen
        {
            get { return _navbarChosen; }
            set { _navbarChosen = value; OnNavbarPropsChanged(); }
        }

        public Components.Navbar NavbarControlMod
        {
            get { return _navbar; }
            set { _navbar = value; }
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
                return ContentViewModel.TemporaryPostsMod;
            }
            else if (ContentType == Enumerations.ChoiceCard.ChoiceCardType.Product)
            {
                if (ContentMode == Enumerations.CustomGrid.CustomGridMode.Beli)
                {
                    return ContentViewModel.TemporaryProductsMod;
                }
                else if (ContentMode == Enumerations.CustomGrid.CustomGridMode.Jual)
                {
                    return ContentViewModel.TemporarySellingProductsMod;
                }
            }
            return [];
        }

        public void RegenerateContents()
        {
            ContentViewModel[] Contents = TemporaryPick();
            DashInit.GenerateChoiceCards(CardGrids: CardGrids, GridType: ContentType, GridMode: ContentMode, parent: this, ContentData: Contents);
            DashInit.UpdateAddButtonVisibility(SearchDash_AddButton: SearchDash_AddButton, GridType: ContentType, GridMode: ContentMode);
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

                NavbarControlMod = DashInit.GenerateNavbar(NavbarControl: NavbarControl, navbarType: NavbarType, navbarChosen: NavbarChosen, parentSearch: this);
                DashInit.GenerateChoiceCards(CardGrids: CardGrids, GridType: ContentType, GridMode: ContentMode, parent: this, ContentData: Contents);
                DashInit.UpdateAddButtonVisibility(SearchDash_AddButton: SearchDash_AddButton, GridType: ContentType, GridMode: ContentMode);

                // Add functionality for SearchDash_AddButton
                SearchDash_AddButton_Button.Click += (s, e) =>
                {
                    if (ContentType == Enumerations.ChoiceCard.ChoiceCardType.Product)
                    {
                        if (ContentMode == Enumerations.CustomGrid.CustomGridMode.Jual)
                        {
                            OpenContent newAddProduct = new OpenContent
                            {
                                PreviousWindow = this,
                                ContentMode = Enumerations.OpenContent.OpenContentBodyMode.Product,
                                ContentType = Enumerations.OpenContent.OpenContentBodyType.Seller,
                                NavbarType = Enumerations.Navbar.NavbarType.User,
                                NavbarChosen = Enumerations.Navbar.NavbarChosen.Jual
                            };

                            Products newProduct = new Products(
                                productId: "",
                                name: "Isi nama produk...",
                                quantity: 0,
                                price: 0,
                                imgSrc: "https://xelltechnology.com/wp-content/uploads/2022/04/dummy1.jpg",
                                description: "Isi deskripsi...",
                                seller: new User(
                                    username: ContentViewModel.ActiveAccount.Username,
                                    password: "",
                                    uuid: ContentViewModel.ActiveAccount.UserUUID
                                )
                            );

                            ContentViewModel newDataContext = new ContentViewModel(
                                product: newProduct
                            );

                            newAddProduct.DataContext = newDataContext;
                            newAddProduct.Show();
                            this.Hide();
                        }
                    }
                    else if (ContentType == Enumerations.ChoiceCard.ChoiceCardType.Post)
                    {
                        /*AddPost newAddPost = new AddPost
                        {
                            PreviousWindow = this,
                            ContentMode = Enumerations.CustomGrid.CustomGridMode.Post,
                            ContentType = Enumerations.ChoiceCard.ChoiceCardType.Post,
                            NavbarType = Enumerations.Navbar.NavbarType.User,
                            NavbarChosen = Enumerations.Navbar.NavbarChosen.Post
                        };

                        newAddPost.DataContext = newAddPost;
                        newAddPost.Show();
                        this.Close();*/
                    }
                };
            };
        }

        private void SearchDash_AddButton_Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}