namespace elecTorn_HUB_Teams.Classes;

// Inherit comment from Post
class Comment : Post
{
    private string _destinationPostId;

    public Comment(string postId, User authorId, string content, string title, string destinationPostId) : base(postId, authorId, content, title)
    {
        _destinationPostId = destinationPostId;
    }

    public string DestinationPostId
    {
        get { return _destinationPostId; }
        set { _destinationPostId = value; }
    }
}