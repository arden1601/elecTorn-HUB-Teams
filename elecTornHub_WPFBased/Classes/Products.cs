namespace elecTornHub_WPFBased.Classes;


public class Products
{
    public string? Name { get; set; }
    public int? Quantity { get; set; }
    public int? Price { get; set; }

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