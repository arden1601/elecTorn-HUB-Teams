using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.ViewModels;

namespace elecTornHub_WPFBased.Components
{
    public partial class Comment : UserControl
    {
        public enum CommentType
        {
            Default,
            Poster,
            Viewer
        }

        public Comment()
        {
            InitializeComponent();
            UpdateLayout();
            DataContext = new CommentViewModel(
                poster: "Mantan Mantumu",
                content: "Lorem ipsum odor amet, consectetuer adipiscing elit. Sapien scelerisque per conubia...",
                postDate: "30 September 1965"
                );
        }

        // DependencyProperty for Type
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(CommentType), typeof(Comment), new PropertyMetadata(CommentType.Default, OnTypeChange));
        public CommentType Type
            {
            get { return (CommentType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        // Callback method for TypeProperty
        public static void OnTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Comment;
            CommentType newType = (CommentType)e.NewValue;

            if (control == null)
                return;

            if (newType == CommentType.Default)
            {
                control.Comment_ButtonBorder.Visibility = Visibility.Collapsed;
                control.Comment_Button.Visibility = Visibility.Collapsed;
            }
            else if (newType == CommentType.Poster)
            {
                control.Comment_Title.Text = "Komentar Anda";
            }
            else if (newType == CommentType.Viewer)
            {
                control.Comment_Button.Content = "Lapor";
            }
        }
    }
}
