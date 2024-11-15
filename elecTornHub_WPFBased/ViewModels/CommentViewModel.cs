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
                    fullName: poster,
                    email: "lol",
                    password: "lol",
                    dateOfBirth: "lol",
                    phoneNumber: "lol",
                    address: "lol",
                    city: "lol",
                    state: "lol",
                    zipCode: "lol",
                    country: "lol"
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
            get => _comment.AuthorId.FullName;
            set
            {
                if (_comment.AuthorId.FullName != value)
                {
                    _comment.AuthorId.FullName = value;
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

        // Property to get and set the date (if you have a Date property in Post)
        /*public string Date
        {
            get => _comment.CreatedAt.ToString("dd MMMM yyyy"); // Assuming CreatedAt is a DateTime in Post
        }*/

        // Implement INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
