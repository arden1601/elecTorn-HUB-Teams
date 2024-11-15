namespace elecTornHub_WPFBased.Classes;

// inherit Tutorial from Post
public class Tutorial : Post
{
    private string _videoUrl;

    public Tutorial(string postId, User authorId, string content, string title, string videoUrl, string postDate) : base(postId, authorId, content, title, postDate)
    {
        _videoUrl = videoUrl;
    }

    public string VideoUrl
    {
        get { return _videoUrl; }
        set { _videoUrl = value; }
    }
}