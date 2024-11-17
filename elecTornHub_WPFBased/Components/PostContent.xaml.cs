using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.Components
{
    public partial class PostContent : UserControl, Interfaces.IPostContent
    {
        // Implement IPostContent interface
        private Enumerations.PostContent.PostContentType _postType;

        public Enumerations.PostContent.PostContentType PostType
        {
            get { return _postType; }
            set { _postType = value; OnTypeChange(value); }
        }

        public PostContent()
        {
            InitializeComponent();
            UpdateLayout();
            this.DataContext = this; // Set DataContext to itse
            PostContent_EditDescription.Visibility = Visibility.Collapsed;
            PostContent_EditTitle.Visibility = Visibility.Collapsed;
            PostContent_ReportSection.Visibility = Visibility.Collapsed;
        }

        public void OnTypeChange(Enumerations.PostContent.PostContentType newValue)
        {
            switch (newValue)
            {
                case Enumerations.PostContent.PostContentType.Default:
                    break;
                case Enumerations.PostContent.PostContentType.Poster:
                    PostContent_EditTitle.Visibility = Visibility.Visible;
                    PostContent_EditDescription.Visibility = Visibility.Visible;

                    PostContent_Title.Visibility = Visibility.Collapsed;
                    PostContent_Description.Visibility = Visibility.Collapsed;
                    PostContent_LogEdit.Visibility = Visibility.Collapsed;
                    break;
                case Enumerations.PostContent.PostContentType.Reported:
                    PostContent_ReportSection.Visibility = Visibility.Visible;
                    break;
                case Enumerations.PostContent.PostContentType.Takedown:
                    PostContent_ReportSection.Visibility = Visibility.Visible;
                    PostContent_ReportButtons.Visibility = Visibility.Collapsed;
                    PostContent_ReportTitle.Text = "Konten telah di-takedown:";
                    break;
            }
        }
    }
}
