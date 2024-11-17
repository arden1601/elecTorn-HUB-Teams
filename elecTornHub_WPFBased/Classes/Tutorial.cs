namespace elecTornHub_WPFBased.Classes;

// inherit Tutorial from Post
public class Tutorial : Post
{
    private string _videoUrl;

    public Tutorial(string postId, User authorId, string content, string title, string videoUrl, string postDate, string lastEdit="", string imgSrc = "") : base(postId, authorId, content, title, postDate, lastEdit, imgSrc)
    {
        _videoUrl = videoUrl;
    }

    public string VideoUrl
    {
        get { return _videoUrl; }
        set { _videoUrl = value; }
    }
}