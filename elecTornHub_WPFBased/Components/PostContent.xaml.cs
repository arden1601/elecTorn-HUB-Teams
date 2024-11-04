using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Components
{
    public partial class PostContent : UserControl
    {
        public PostContent()
        {
            InitializeComponent();
            UpdateLayout();
            this.DataContext = this; // Set DataContext to itse
            PostContent_EditDescription.Visibility = Visibility.Collapsed;
            PostContent_EditTitle.Visibility = Visibility.Collapsed;
            PostContent_ReportSection.Visibility = Visibility.Collapsed;
        }

        // DependencyProperty for Type
        public enum PostContentType
        {
            Default,
            Poster,
            Reported,
            Takedown
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(PostContentType), typeof(PostContent), new PropertyMetadata(PostContentType.Default, OnTypeChange));
        public PostContentType Type
            {
            get { return (PostContentType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty

        public static void OnTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as PostContent;

            if (control == null)
                return;

            PostContentType newType = (PostContentType)e.NewValue;

            if (newType == PostContentType.Default)
            {

            } else if (newType == PostContentType.Poster)
            {
                control.PostContent_EditTitle.Visibility = Visibility.Visible;
                control.PostContent_EditDescription.Visibility = Visibility.Visible;

                control.PostContent_Title.Visibility = Visibility.Collapsed;
                control.PostContent_Description.Visibility = Visibility.Collapsed;
                control.PostContent_LogEdit.Visibility = Visibility.Collapsed;
            } else if (newType == PostContentType.Reported)
            {
                control.PostContent_ReportSection.Visibility = Visibility.Visible;
            } else if (newType == PostContentType.Takedown)
            {
                control.PostContent_ReportSection.Visibility = Visibility.Visible;
                control.PostContent_ReportButtons.Visibility = Visibility.Collapsed;
                control.PostContent_ReportTitle.Text = "Konten telah di-takedown:";
            }
        }
    }
}
