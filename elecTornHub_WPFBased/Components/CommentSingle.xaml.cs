using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.ViewModels;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Components
{
    public partial class CommentSingle : UserControl, Interfaces.IComment
    {
        // Implementing IComment interface
        private Enumerations.Comment.CommentType _commentType;
        private string _commentPoster;
        private string _commentContent;
        private string _commentPostDate;

        public Enumerations.Comment.CommentType CommentType
        {
            get { return _commentType; }
            set { _commentType = value; OnTypeChange(value); }
        }

        public string Comment_Poster
        {
            get { return _commentPoster; }
            set { _commentPoster = value; UpdateDataContext(); }
        }

        public string Comment_Content
        {
            get { return _commentContent; }
            set { _commentContent = value; UpdateDataContext(); }
        }

        public string Comment_PostDate
        {
            get { return _commentPostDate; }
            set { _commentPostDate = value; UpdateDataContext(); }
        }

        public CommentSingle()
        {
            InitializeComponent();
            UpdateLayout();
            UpdateDataContext();
        }

        private void UpdateDataContext()
        {
            DataContext = new CommentViewModel(
                poster: Comment_Poster,
                content: Comment_Content,
                postDate: Comment_PostDate
                );
        }

        // Callback method for TypeProperty
        private void OnTypeChange(Enumerations.Comment.CommentType newType)
        {
            if (newType == Enumerations.Comment.CommentType.Default)
            {
                Comment_ButtonBorder.Visibility = Visibility.Collapsed;
                Comment_Button.Visibility = Visibility.Collapsed;
            }
            else if (newType == Enumerations.Comment.CommentType.Poster)
            {
                Comment_Title.Text = "Komentar Anda";
            }
            else if (newType == Enumerations.Comment.CommentType.Viewer)
            {
                Comment_Button.Content = "Lapor";
            }
        }
    }
}
