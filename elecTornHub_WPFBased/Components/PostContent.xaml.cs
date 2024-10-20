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
            this.DataContext = this; // Set DataContext to itse
            PostContent_EditDescription.Visibility = Visibility.Collapsed;
            PostContent_EditTitle.Visibility = Visibility.Collapsed;
            PostContent_ReportSection.Visibility = Visibility.Collapsed;
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(PostContent), new PropertyMetadata(string.Empty, OnTypeChange));
        public string Type
            {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        public static void OnTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as PostContent;
            string newType = e.NewValue as string;

            if (newType == "Default")
            {

            } else if (newType == "Poster")
            {
                control.PostContent_EditTitle.Visibility = Visibility.Visible;
                control.PostContent_EditDescription.Visibility = Visibility.Visible;

                control.PostContent_Title.Visibility = Visibility.Collapsed;
                control.PostContent_Description.Visibility = Visibility.Collapsed;
                control.PostContent_LogEdit.Visibility = Visibility.Collapsed;
            } else if (newType == "Reported")
            {
                control.PostContent_ReportSection.Visibility = Visibility.Visible;
            } else if (newType == "Takedown")
            {
                control.PostContent_ReportSection.Visibility = Visibility.Visible;
                control.PostContent_ReportButtons.Visibility = Visibility.Collapsed;
                control.PostContent_ReportTitle.Text = "Konten telah di-takedown:";
            }
        }
    }
}
