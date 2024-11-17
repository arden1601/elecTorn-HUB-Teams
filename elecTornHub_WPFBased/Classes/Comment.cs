namespace elecTornHub_WPFBased.Classes
{
    // Make Comment class public
    public class Comment
    {
        private string postId;
        private User authorId;
        private string content;
        private string _destinationPostId;
        private string postDate;

        public string PostId
        {
            get { return postId; }
            set { postId = value; }
        }

        public User AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string PostDate
        {
            get { return postDate; }
            set { postDate = value; }
        }

        public Comment(string postId, User authorId, string content, string postDate) 
        {
            this.postId = postId;
            this.authorId = authorId;
            this.content = content;
            this.postDate = postDate;
        }

        public string DestinationPostId
        {
            get { return _destinationPostId; }
            set { _destinationPostId = value; }
        }
    }
}
