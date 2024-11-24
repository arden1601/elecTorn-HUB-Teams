using elecTornHub_WPFBased.ViewModels;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using elecTornHub_WPFBased.Extras;
namespace elecTornHub_WPFBased.Classes;

public class Post
{
    private string _postId;
    private User _authorId;
    private string _content;
    private string _title;
    private string _postDate;
    private string _lastEdit;
    private string _imgSrc;
    private CommentViewModel[] _comments;

    public Post(string postId, User authorId, string content, string title, string postDate, string imgSrc, string lastEdit, CommentViewModel[] comments)
    {
        _postId = postId;
        _authorId = authorId;
        _content = content;
        _title = title;
        _postDate = postDate;
        _imgSrc = imgSrc ?? "";
        _lastEdit = lastEdit;
        _comments = comments;
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

    public string LastEdit
    {
        get { return _lastEdit; }
        set { _lastEdit = value; }
    }

    public string ImgSrc
    {
        get { return _imgSrc; }
        set { _imgSrc = value; }
    }

    public CommentViewModel[] Comments
    {
        get { return _comments; }
        set { _comments = value; }
    }

    public void Takedown()
    {
        _content = "This post has been taken down.";
    }

    public static async Task<List<dynamic>> getPosting()
    {
        var data = new List<dynamic>();
        using (HttpClient httpClient = new HttpClient())
        {
            HttpResponseMessage response = await httpClient.GetAsync(Variables.APIURI.contentURI);

            var jsonData = await response.Content.ReadAsStringAsync();
            data = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);
            return data;
        }
    }

    
}