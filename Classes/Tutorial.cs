namespace elecTorn_HUB_Teams.Classes;

// inherit Tutorial from Post
class Tutorial : Post
{
    private string _videoUrl;

    public Tutorial(string postId, User authorId, string content, string title, string videoUrl) : base(postId, authorId, content, title)
    {
        _videoUrl = videoUrl;
    }

    public string VideoUrl
    {
        get { return _videoUrl; }
        set { _videoUrl = value; }
    }
}