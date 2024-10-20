using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace elecTornHub_WPFBased.Components
{
    public partial class Comment : UserControl
    {
        public Comment()
        {
            InitializeComponent();
            this.DataContext = this; // Set DataContext to itse
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(Comment), new PropertyMetadata(string.Empty, OnTypeChange));
        public string Type
            {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        public static void OnTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Comment;
            string newType = e.NewValue as string;

            if (newType == "Default")
            {
                control.Comment_ButtonBorder.Visibility = Visibility.Collapsed;
            }
            else if (newType == "Poster")
            {
                control.Comment_Title.Text = "Komentar Anda";
            }
            else if (newType == "Viewer")
            {
                control.Comment_Button.Content = "Lapor";
            }
        }
    }
}
