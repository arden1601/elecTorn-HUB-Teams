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
}