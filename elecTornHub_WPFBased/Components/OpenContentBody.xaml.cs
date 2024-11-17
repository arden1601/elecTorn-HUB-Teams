namespace elecTornHub_WPFBased.Components
{
    using elecTornHub_WPFBased.Extras;
    using elecTornHub_WPFBased.ViewModels;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class OpenContentBody : UserControl, Interfaces.IOpenContent
    {
        // Implement IOpenContent interface
        private Enumerations.OpenContent.OpenContentBodyType _openContentType;
        private Enumerations.OpenContent.OpenContentBodyMode _openContentMode;

        public Enumerations.OpenContent.OpenContentBodyType ContentType
        {
            get { return _openContentType; }
            set { _openContentType = value; OnTypeChanged(value); }
        }

        public Enumerations.OpenContent.OpenContentBodyMode ContentMode
        {
            get { return _openContentMode; }
            set { _openContentMode = value; OnModeChanged(value); }
        }

        private void OnTypeChanged(Enumerations.OpenContent.OpenContentBodyType newValue)
        {
            switch (newValue)
            {
                case Enumerations.OpenContent.OpenContentBodyType.Buyer:
                    OpenContentBody_Button1.Visibility = Visibility.Visible;
                    OpenContentBody_Button1.Width = double.NaN;
                    OpenContentBody_Button1.Margin = new Thickness(0, 0, 10, 0);

                    OpenContentBody_Button2.Visibility = Visibility.Visible;
                    OpenContentBody_Button2.Width = double.NaN;
                    OpenContentBody_Button2.Margin = new Thickness(0, 0, 10, 0);

                    OpenContentBody_Button3.Visibility = Visibility.Visible;
                    OpenContentBody_Button3.Width = double.NaN;

                    OpenContentBody_Counter.Visibility = Visibility.Visible;
                    OpenContentBody_Counter.Width = double.NaN;
                    OpenContentBody_Counter.Margin = new Thickness(0, 0, 10, 0);
                    break;
                case Enumerations.OpenContent.OpenContentBodyType.Seller:
                    OpenContentBody_Seller.Visibility = Visibility.Collapsed;
                    OpenContentBody_Stock.Visibility = Visibility.Collapsed;

                    OpenContentBody_Button3.Visibility = Visibility.Visible;
                    OpenContentBody_Button3.Width = double.NaN;
                    OpenContentBody_Button3_Button.Content = "Hapus Jualan";

                    OpenContentBody_Counter.Visibility = Visibility.Visible;
                    OpenContentBody_Counter.Width = double.NaN;
                    OpenContentBody_Counter.Margin = new Thickness(0, 0, 10, 0);

                    OpenContentBody_EditTitleBorder.Visibility = Visibility.Visible;
                    OpenContentBody_Title.Visibility = Visibility.Collapsed;

                    OpenContentBody_EditDescBorder.Visibility = Visibility.Visible;
                    OpenContentBody_DescBorder.Visibility = Visibility.Collapsed;

                    OpenContentBody_EditPriceBorder.Visibility = Visibility.Visible;
                    OpenContentBody_Price.Visibility = Visibility.Collapsed;
                    break;
                case Enumerations.OpenContent.OpenContentBodyType.Reported:
                    OpenContentBody_Button1.Visibility = Visibility.Visible;
                    OpenContentBody_Button1.Width = double.NaN;
                    OpenContentBody_Button1.Background = Variables.ColorDarkGray;
                    OpenContentBody_Button1.Margin = new Thickness(0, 0, 10, 0);
                    OpenContentBody_Button1_Button.Content = "Tolak";

                    OpenContentBody_Button2.Visibility = Visibility.Visible;
                    OpenContentBody_Button2.Width = double.NaN;
                    OpenContentBody_Button2.Background = Variables.ColorAccentOrange;
                    OpenContentBody_Button2.Margin = new Thickness(0, 0, 10, 0);
                    OpenContentBody_Button2_Button.Content = "Takedown";

                    OpenContentBody_Button3.Visibility = Visibility.Visible;
                    OpenContentBody_Button3.Width = double.NaN;
                    OpenContentBody_Button3_Button.Content = "Ban User";

                    OpenContentBody_ReportTab.Visibility = Visibility.Visible;
                    break;
                case Enumerations.OpenContent.OpenContentBodyType.Banned:
                    OpenContentBody_Button3.Visibility = Visibility.Visible;
                    OpenContentBody_Button3.Width = double.NaN;
                    OpenContentBody_Button3_Button.Content = "Hapus Jualan";
                    OpenContentBody_ReportTab_Title.Text = "Produk telah di-takedown:";
                    OpenContentBody_ReportTab.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void OnModeChanged(Enumerations.OpenContent.OpenContentBodyMode newValue)
        {
            switch (newValue)
            {
                case Enumerations.OpenContent.OpenContentBodyMode.Product:
                    OpenContentBody_ModeProduct.Visibility = Visibility.Visible;
                    break;
                case Enumerations.OpenContent.OpenContentBodyMode.Post:
                    OpenContentBody_ModePost.Visibility = Visibility.Visible;
                    OpenContentBody_BorderParent.Height = double.NaN;
                    break;
                default:
                    break;
            }
        }

        public OpenContentBody()
        {
            InitializeComponent();
            Initialize();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is ContentViewModel viewModel)
            {
                // Generate comments when DataContext changes
                if (viewModel.Post_Comments != null)
                {
                    GenerateComments(viewModel.Post_Comments);
                }
            }
        }

        private void Initialize()
        {
            OpenContentBody_ModePost.Visibility = Visibility.Collapsed;
            OpenContentBody_ModeProduct.Visibility = Visibility.Collapsed;

            // Hide all buttons and counter
            ClearProps(OpenContentBody_Button1);
            ClearProps(OpenContentBody_Button2);
            ClearProps(OpenContentBody_Button3);
            ClearProps(OpenContentBody_Counter);
            OpenContentBody_ReportTab.Visibility = Visibility.Collapsed;
            OpenContentBody_EditTitleBorder.Visibility = Visibility.Collapsed;
            OpenContentBody_EditDescBorder.Visibility = Visibility.Collapsed;
            OpenContentBody_EditPriceBorder.Visibility = Visibility.Collapsed;
        }

        private void GenerateComments(CommentViewModel[] comments)
        {
            OpenContentBody_CommentGrid.Children.Clear();

            int count = comments.Length;
            for (int i = 0; i < count; i++)
            {
                // Rand numb from 1 to 2 using random from C, don't use Variables.Random, i dont have it
                int rand = new System.Random().Next(1, 3);

                OpenContentBody_CommentGrid.Children.Add(new CommentSingle
                {
                    CommentType = rand == 1 ? Enumerations.Comment.CommentType.Poster : Enumerations.Comment.CommentType.Viewer,
                    DataContext = comments[i]
                });

                OpenContentBody_CommentGrid.UpdateLayout();
                UpdateLayout();
            }
        }

        private void ClearProps(Border border)
        {
            border.Visibility = Visibility.Hidden;
            border.Width = 0;
            border.Margin = new Thickness(0);
        }

        private void ClearProps(CounterButton button)
        {
            button.Visibility = Visibility.Hidden;
            button.Width = 0;
            button.Margin = new Thickness(0);
        }
    }
}