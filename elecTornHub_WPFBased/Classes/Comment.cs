namespace elecTornHub_WPFBased.Classes
{
    // Make Comment class public
    public class Comment : Post
    {
        private string _destinationPostId;

        public Comment(string postId, User authorId, string content, string title, string destinationPostId, string postDate, string imgSrc = "") 
            : base(postId, authorId, content, title, postDate, imgSrc)
        {
            _destinationPostId = destinationPostId;
        }

        public string DestinationPostId
        {
            get { return _destinationPostId; }
            set { _destinationPostId = value; }
        }
    }
}
