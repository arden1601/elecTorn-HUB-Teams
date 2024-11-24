﻿namespace elecTornHub_WPFBased.Components
{
    using elecTornHub_WPFBased.Extras;
    using elecTornHub_WPFBased.Pages;
    using elecTornHub_WPFBased.ViewModels;
    using System.Net.Mime;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class OpenContentBody : UserControl, Interfaces.IOpenContent
    {

        // Implement IOpenContent interface
        private Enumerations.OpenContent.OpenContentBodyType _openContentType;
        private Enumerations.OpenContent.OpenContentBodyMode _openContentMode;
        private OpenContent _parentContent;

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

        public OpenContent parentContent
        {
            get { return _parentContent; }
            set { _parentContent = value; }
        }

        private void OnTypeChanged(Enumerations.OpenContent.OpenContentBodyType newValue)
        {
            CounterButton counterButton = new CounterButton();
            
            counterButton.Counter_Add.Click += (s, e) =>
            {
                Functions.ClickDataHandler(
                    DataContext: DataContext,
                    callback: (viewModel) =>
                    {
                        if (viewModel.ProductCard_Id != null)
                        {
                            if (viewModel.ProductCard_Quantity + 1 <= 99)
                            {
                                viewModel.ProductCard_Quantity += 1;
                                counterButton.Count = viewModel.ProductCard_Quantity;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stock is null or inaccessible.");
                        }
                    }
                );
            };

            counterButton.Counter_Min.Click += (s, e) =>
            {
                Functions.ClickDataHandler(
                    DataContext: DataContext,
                    callback: (viewModel) =>
                    {
                        if (viewModel.ProductCard_Id != null)
                        {
                            if (viewModel.ProductCard_Quantity - 1 >= 0)
                            {
                                viewModel.ProductCard_Quantity -= 1;
                                counterButton.Count = viewModel.ProductCard_Quantity;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Post_Id is null or inaccessible.");
                        }
                    }
                );
            };

            counterButton.Loaded += (s, e) =>
            {
                if (DataContext is ContentViewModel viewModel)
                {
                    // Set the initial value of Count when the DataContext is available
                    counterButton.Count = viewModel.ProductCard_Quantity;
                }
            };

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

                    OpenContentBody_CounterButtonContainer.Children.Add(counterButton);

                    break;
                case Enumerations.OpenContent.OpenContentBodyType.Seller:
                    OpenContentBody_Seller.Visibility = Visibility.Collapsed;
                    OpenContentBody_Stock.Visibility = Visibility.Collapsed;

                    OpenContentBody_Button1.Visibility = Visibility.Visible;
                    OpenContentBody_Button1.Width = double.NaN;
                    OpenContentBody_Button1_Button.Content = "Konfirmasi";
                    OpenContentBody_Button1.Margin = new Thickness(0, 0, 10, 0);

                    OpenContentBody_Button1_Button.Click += (s, e) =>
                    {
                        Functions.ClickDataHandler(
                            DataContext: DataContext,
                            callback: (viewModel) =>
                            {
                                if (viewModel.ProductCard_Id == "")
                                {
                                    // Random id generator (not using Math)
                                    viewModel.ProductCard_Id = new System.Random().Next(100000, 999999).ToString();

                                    ContentViewModel.TemporarySellingProductsMod = ContentViewModel.PushOne(
                                        arrIn: ContentViewModel.TemporarySellingProductsMod,
                                        item: viewModel
                                    );

                                    parentContent.NavbarControlMod.ReturnToPrevious();
                                }
                                else if (viewModel.ProductCard_Id != null)
                                {

                                    parentContent.NavbarControlMod.ReturnToPrevious();
                                }
                                else
                                {
                                    MessageBox.Show("Post_Id is null or inaccessible.");
                                }
                            }
                            );
                    };

                    OpenContentBody_Button3.Visibility = Visibility.Visible;
                    OpenContentBody_Button3.Width = double.NaN;
                    OpenContentBody_Button3_Button.Content = "Hapus Jualan";

                    OpenContentBody_Button3_Button.Click += (s, e) =>
                    {
                        Functions.ClickDataHandler(
                            DataContext: DataContext,
                            callback: (viewModel) =>
                            {
                                if (viewModel.ProductCard_Id != null)
                                {
                                    string selectedId = viewModel.ProductCard_Id;
                                    ContentViewModel.TemporarySellingProductsMod = ContentViewModel.DeleteById(
                                        arrIn: ContentViewModel.TemporarySellingProductsMod,
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

                    OpenContentBody_CounterButtonContainer.Children.Add(counterButton);

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

        private void Counter_Add_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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

        public OpenContentBody(OpenContent parentContent, Enumerations.OpenContent.OpenContentBodyType contentType, Enumerations.OpenContent.OpenContentBodyMode contentMode, ContentViewModel dataContext)
        {
            InitializeComponent();
            Initialize();
            DataContextChanged += OnDataContextChanged;
            this.parentContent = parentContent;
            ContentType = contentType;
            ContentMode = contentMode;
            DataContext = dataContext;
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

            // Hide all buttons
            ClearProps(OpenContentBody_Button1);
            ClearProps(OpenContentBody_Button2);
            ClearProps(OpenContentBody_Button3);
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