using elecTornHub_WPFBased.Extras;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

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

        public async Task PostCommentAsync(string endpointUrl)
        {
            var requestBody = new
            {
                content = this.content,
                postId = this.postId
            };

            using (HttpClient httpClient = new HttpClient())
            {
                // Serialize the request body to JSON
                var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                try
                {
                    // Send POST request
                    HttpResponseMessage response = await httpClient.PostAsync(endpointUrl, jsonContent);

                    // Check if the response is successful
                    response.EnsureSuccessStatusCode();

                    // Read response content
                    var jsonData = await response.Content.ReadAsStringAsync();

                    // Deserialize response if necessary
                    var data = JsonConvert.DeserializeObject<dynamic>(jsonData);
                    Console.WriteLine($"Response: {data}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
