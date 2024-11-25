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
        public CommentViewModel(User author, string content, string postDate, string postId, string commentId)
        {
            // fill the values
            _comment = new Comment(
                commentId: commentId,
                authorId: author,
                content: content,
                postDate: postDate,
                postId: postId
            );
        }

        // CRUD operations
        public static async Task<CommentViewModel[]> PushOne(string postId, CommentViewModel comment)
        {
            // Get the content
            ContentViewModel getContent = ContentViewModel.GetById(ContentViewModel.TemporaryPostsMod, postId);
            CommentViewModel[] existingComments = getContent.Post_Comments;

            // Append
            List<CommentViewModel> newComments = new List<CommentViewModel>(existingComments);
            newComments.Add(comment);

            // Update
            getContent.Post_Comments = newComments.ToArray();

            // Return the updated comments
            return newComments.ToArray();
        }

        public static async Task<CommentViewModel[]> DeleteOne(string postId, string commentId)
        {
            // Split the selected content with the rest
            ContentViewModel getContent = ContentViewModel.GetById(ContentViewModel.TemporaryPostsMod, postId);
            
            // Get the comments
            CommentViewModel[] existingComments = getContent.Post_Comments;

            // Remove the selected comment
            List<CommentViewModel> newComments = new List<CommentViewModel>(existingComments);
            newComments.RemoveAll(comment => comment.CommentId == commentId);

            // Update
            getContent.Post_Comments = newComments.ToArray();

            // Return the updated comments
            return newComments.ToArray();
        }

        // Property to get and set the title from the Comment data model

        public string CommentId
        {
            get => _comment.CommentId;
            set
            {
                if (_comment.CommentId != value)
                {
                    _comment.CommentId = value;
                    OnPropertyChanged(nameof(CommentId));
                }
            }
        }

        public User Poster
        {
            get => _comment.AuthorId;
            set
            {
                if (_comment.AuthorId != value)
                {
                    _comment.AuthorId = value;
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

        public string PostId
            {
            get => _comment.PostId;
            set
            {
                if (_comment.PostId != value)
                {
                    _comment.PostId = value;
                    OnPropertyChanged(nameof(PostId));
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
