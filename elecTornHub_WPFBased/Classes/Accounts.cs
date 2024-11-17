using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Windows;

namespace elecTornHub_WPFBased.Classes;

public class Accounts
{
    public string? Username { get; set; }
    public string? Password { get; set; }

    public string? UserUUID { get; set; }

    public Accounts(){

    }

    public Accounts(string username, string password, string uuid)
    {
        Username = username;
        Password = password;
        UserUUID = uuid;
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
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
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