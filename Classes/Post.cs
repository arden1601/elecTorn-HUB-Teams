namespace elecTorn_HUB_Teams.Classes;

class Post
{
    private string _postId;
    private User _authorId;
    private string _content;
    private string _title;

    public Post(string postId, User authorId, string content, string title)
    {
        _postId = postId;
        _authorId = authorId;
        _content = content;
        _title = title;
    }

    public string PostId
    {
        get { return _postId; }
        set { _postId = value; }
    }

    public User AuthorId
    {
        get { return _authorId; }
        set { _authorId = value; }
    }

    public string Content
    {
        get { return _content; }
        set { _content = value; }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public void Takedown()
    {
        _content = "This post has been taken down.";
    }
}