using System.Windows;
using static elecTornHub_WPFBased.Extras.Variables;
using elecTornHub_WPFBased.Components;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Pages
{
    public partial class OpenContent : Window, Interfaces.INavbarParent, Interfaces.IContent
    {
        // Implement INavbarParent
        private Enumerations.Navbar.NavbarType _navbarType;
        private Enumerations.Navbar.NavbarChosen _navbarChosen;

        public Enumerations.Navbar.NavbarType NavbarType
        {
            get { return _navbarType; }
            set { _navbarType = value; OnNavbarPropsChanged(); }
        }

        public Enumerations.Navbar.NavbarChosen NavbarChosen
        {
            get { return _navbarChosen; }
            set { _navbarChosen = value; OnNavbarPropsChanged(); }
        }

        private void OnNavbarPropsChanged()
        {
            DashInit.UpdateNavbar(
                    NavbarControl: NavbarControl,
                    NavbarType: NavbarType,
                    NavbarChosen: NavbarChosen
                );
        }

        // Implement IContent
        private Enumerations.OpenContent.OpenContentBodyMode _contentMode;
        private Enumerations.OpenContent.OpenContentBodyType _contentType;
        private Enumerations.PostContent.PostContentType _postType;

        public Enumerations.OpenContent.OpenContentBodyMode ContentMode
        {
            get { return _contentMode; }
            set { _contentMode = value; }
        }

        public Enumerations.OpenContent.OpenContentBodyType ContentType
        {
            get { return _contentType; }
            set { _contentType = value; }
        }

        public Enumerations.PostContent.PostContentType PostType
        {
            get { return _postType; }
            set { _postType = value; }
        }

        public void RegenerateContents()
        {
            DashInit.GenerateContent(
                parentGrid: OpenContentControl,
                ContentType: ContentType,
                ContentMode: ContentMode,
                PostType: PostType
            );
        }

        public SearchDash PreviousWindow { get; set; }

        private Boolean _killingParent = true;

        public Boolean KillingParent
        {
            get { return _killingParent; }
            set { _killingParent = value; }
        }

        public OpenContent()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (s, e) =>
            {
                DashInit.GenerateNavbar(NavbarControl, navbarType: NavbarType, navbarChosen: NavbarChosen, previousWindow: PreviousWindow, parentContent: this);
                DashInit.GenerateContent(OpenContentControl, ContentType, ContentMode, PostType);
            };

            Closed += OpenContent_Closed;
        }

        // Cleanup when the window is closed
        public void OpenContent_Closed(object sender, EventArgs e)
        {
            if (KillingParent)
            {
                PreviousWindow?.Close();
                PreviousWindow = null;
            }
        }
    }
}
