using System.ComponentModel;
using elecTornHub_WPFBased.Classes;

namespace elecTornHub_WPFBased.ViewModels
{
    public class CommentViewModel : INotifyPropertyChanged
    {
        private Comment _comment;

        public CommentViewModel(Comment comment)
        {
            _comment = comment;
        }

        // Temporary constructor to accept value directly
        public CommentViewModel(string poster, string content, string postDate)
        {
            // fill the values
            _comment = new Comment(
                postId: "lol",
                authorId: new User(
                    username: "lol",
                    password: "lol",
                    uuid: "lalala"
                ),
                content: content,
                title: "",
                destinationPostId: "lol",
                postDate: postDate
                );
        }

        // Property to get and set the title from the Comment data model
        public string Poster
        {
            get => _comment.AuthorId.Username;
            set
            {
                if (_comment.AuthorId.Username != value)
                {
                    _comment.AuthorId.Username = value;
                    OnPropertyChanged(nameof(Poster));
                }
            }
        }

        // Property to get and set the content
        public string Content
        {
            get => _comment.Content;
            set
            {
                if (_comment.Content != value)
                {
                    _comment.Content = value;
                    OnPropertyChanged(nameof(Content));
                }
            }
        }

        // Property to get and set the post date
        public string PostDate
        {
            get => _comment.PostDate;
            set
            {
                if (_comment.PostDate != value)
                {
                    _comment.PostDate = value;
                    OnPropertyChanged(nameof(PostDate));
                }
            }
        }

        // Property to get and set the destination post ID
        public string DestinationPostId
        {
            get => _comment.DestinationPostId;
            set
            {
                if (_comment.DestinationPostId != value)
                {
                    _comment.DestinationPostId = value;
                    OnPropertyChanged(nameof(DestinationPostId));
                }
            }
        }

        // Implement INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
