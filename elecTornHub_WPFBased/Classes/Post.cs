namespace elecTornHub_WPFBased.Classes;

public class Post
{
    private string _postId;
    private User _authorId;
    private string _content;
    private string _title;
    private string _postDate;
    private string _imgSrc;

    public Post(string postId, User authorId, string content, string title, string postDate, string imgSrc)
    {
        _postId = postId;
        _authorId = authorId;
        _content = content;
        _title = title;
        _postDate = postDate;
        _imgSrc = imgSrc ?? "";
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

    public string PostDate
    {
        get { return _postDate; }
        set { _postDate = value; }
    }

    public string ImgSrc
    {
        get { return _imgSrc; }
        set { _imgSrc = value; }
    }

    public void Takedown()
    {
        _content = "This post has been taken down.";
    }
}