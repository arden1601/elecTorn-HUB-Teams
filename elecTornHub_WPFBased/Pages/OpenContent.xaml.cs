using System.Windows;
using static elecTornHub_WPFBased.Extras.Variables;
using elecTornHub_WPFBased.Components;

namespace elecTornHub_WPFBased.Pages
{
    public partial class OpenContent : Window
    {
        public void RegenerateContents()
        {
            DashInit.GenerateContent(OpenContentControl, ContentType, ContentMode, PostType);
        }

        public OpenContent()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (s, e) =>
            {
                DashInit.GenerateNavbar(NavbarControl, this);
                DashInit.GenerateContent(OpenContentControl, ContentType, ContentMode, PostType);
            };
        }

        public Window PreviousWindow { get; set; }
        
        // DependancyProperty for PostType
        public static readonly DependencyProperty PostTypeProperty =
            DependencyProperty.Register("PostType", typeof(PostContent.PostContentType), typeof(OpenContent), new PropertyMetadata(PostContent.PostContentType.Default, OnPostTypeChanged));

        public PostContent.PostContentType PostType
        {
            get { return (PostContent.PostContentType)GetValue(PostTypeProperty); }
            set { SetValue(PostTypeProperty, value); }
        }

        // Define NavbarType as a DependencyProperty
        public static readonly DependencyProperty NavbarTypeProperty =
            DependencyProperty.Register(nameof(NavbarType), typeof(Navbar.NavbarType), typeof(OpenContent),
                new PropertyMetadata(Navbar.NavbarType.Default, OnNavbarTypeChanged));

        public Navbar.NavbarType NavbarType
        {
            get => (Navbar.NavbarType)GetValue(NavbarTypeProperty);
            set => SetValue(NavbarTypeProperty, value);
        }

        // Define NavbarChosen as a DependencyProperty
        public static readonly DependencyProperty NavbarChosenProperty =
            DependencyProperty.Register(nameof(NavbarChosen), typeof(Navbar.NavbarChosen), typeof(OpenContent),
                new PropertyMetadata(Navbar.NavbarChosen.Default, OnNavbarChosenChanged));

        public Navbar.NavbarChosen NavbarChosen
        {
            get => (Navbar.NavbarChosen)GetValue(NavbarChosenProperty);
            set => SetValue(NavbarChosenProperty, value);
        }

        // DependencyProperty for ContentType
        public static readonly DependencyProperty ContentTypeProperty =
            DependencyProperty.Register(nameof(ContentType), typeof(OpenContentBody.OpenContentBodyType), typeof(OpenContent),
                new PropertyMetadata(OpenContentBody.OpenContentBodyType.Default, OnContentTypeChanged));

        public OpenContentBody.OpenContentBodyType ContentType
        {
            get => (OpenContentBody.OpenContentBodyType)GetValue(ContentTypeProperty);
            set => SetValue(ContentTypeProperty, value);
        }

        // DependencyProperty for ContentMode
        public static readonly DependencyProperty ContentModeProperty =
            DependencyProperty.Register(nameof(ContentMode), typeof(OpenContentBody.OpenContentBodyMode), typeof(OpenContent),
                new PropertyMetadata(OpenContentBody.OpenContentBodyMode.Default, OnContentModeChanged));

        public OpenContentBody.OpenContentBodyMode ContentMode
        {
            get => (OpenContentBody.OpenContentBodyMode)GetValue(ContentModeProperty);
            set => SetValue(ContentModeProperty, value);
        }

        private static void OnContentTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var openContent = d as OpenContent;

            if (openContent == null) return;

            openContent.ContentType = (OpenContentBody.OpenContentBodyType)e.NewValue;
        }

        private static void OnContentModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var openContent = d as OpenContent;

            if (openContent == null) return;

            openContent.ContentMode = (OpenContentBody.OpenContentBodyMode)e.NewValue;
        }

        private static void OnNavbarTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var openContent = (OpenContent)d; // Corrected to OpenContent
            openContent.NavbarType = (Navbar.NavbarType)e.NewValue;
            DashInit.UpdateNavbar(openContent.NavbarControl, openContent.NavbarType, openContent.NavbarChosen);
        }

        private static void OnNavbarChosenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var openContent = (OpenContent)d; // Corrected to OpenContent
            openContent.NavbarChosen = (Navbar.NavbarChosen)e.NewValue;
            DashInit.UpdateNavbar(openContent.NavbarControl, openContent.NavbarType, openContent.NavbarChosen);
        }

        private static void OnPostTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (OpenContent)d;
            control.PostType = (PostContent.PostContentType)e.NewValue;
        }
    }
}
