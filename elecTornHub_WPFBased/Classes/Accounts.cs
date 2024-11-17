using System.Net.Http;
using System.Text;
using System.Windows;
using Newtonsoft.Json;

namespace elecTornHub_WPFBased.Classes;

public class Accounts
{
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? UserUUID { get; set; }
        public string? Role { get; set; } // Add a Role property

        public Accounts() { }

        public Accounts(string username, string password, string uuid, string role = "")
        {
            Username = username;
            Password = password;
            UserUUID = uuid;
            Role = role;
        }

        public async Task<bool> Login()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://api-junpro.vercel.app/login";

                var requestData = new
                {
                    username = Username,
                    password = Password,
                };

                string json = JsonConvert.SerializeObject(requestData);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Send the POST request
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and parse the response
                        string responseJson = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<dynamic>(responseJson);

                        // Set the UserUUID and Role properties
                        UserUUID = responseData?.uuid;
                        Role = responseData?.role;

                        return true; // Login successful
                    }
                    else
                    {
                        return false; // Login failed
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    return false;
                }
            }
        }

    public void Register()
    {
        // Login the account
    }

    public void Logout()
    {
        // Logout the account
    }

}