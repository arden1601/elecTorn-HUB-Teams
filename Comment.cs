namespace elecTorn_HUB_Teams;

// Inherit comment from Post
class Comment : Post {
    private string _destinationPostId;

    public Comment(string postId, string authorId, string content, string title, string destinationPostId) : base(postId, authorId, content, title) {
        _destinationPostId = destinationPostId;
    }

    public string DestinationPostId {
        get { return _destinationPostId; }
        set { _destinationPostId = value; }
    }
}