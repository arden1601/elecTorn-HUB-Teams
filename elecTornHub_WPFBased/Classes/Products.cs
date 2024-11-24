using elecTornHub_WPFBased.Extras;
using Newtonsoft.Json;
using System.Net.Http;

namespace elecTornHub_WPFBased.Classes;


public class Products
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string ImgSrc { get; set; }
    public string Description { get; set; }
    public User Seller { get; set; }

    public Products(string productId, string name, int quantity, int price, string imgSrc, string description, User seller)
    {
        ProductId = productId;
        Name = name;
        Quantity = quantity;
        Price = price;
        ImgSrc = imgSrc;
        Description = description;
        Seller = seller;
    }

    public void Buy()
    {
        Console.WriteLine("Buying Logic is running here");
    }

    public void Sell()
    {
        Console.WriteLine("Selling Logic is running here");
    }

    public void Edit()
    {
        Console.WriteLine("Editing Logic is running here");
    }

    // get all products untuk tab beli
    public static async Task<List<dynamic>> getAllProduct() 
    {
        var data = new List<dynamic>();
        using (HttpClient httpClient = new HttpClient())
        {
            HttpResponseMessage response = await httpClient.GetAsync(Variables.APIURI.getAllProduct);

            var jsonData = await response.Content.ReadAsStringAsync();
            data = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);
            
            return data;
        }
    }

    // get all products untuk tab jual karena ini adalah product pribadi
    public static async Task<List<dynamic>> getOwnProduct()
    {
        var data = new List<dynamic>();
        using (HttpClient httpClient = new HttpClient())
        {
            HttpResponseMessage response = await httpClient.GetAsync(Variables.APIURI.getAllProduct);

            var jsonData = await response.Content.ReadAsStringAsync();
            data = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);
            
            return data;
        }
    }
}