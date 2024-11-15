namespace elecTornHub_WPFBased.Classes;

public class User : Accounts
{
    // Inherit constructor
    public User(string username, string password, string email, string phoneNumber, string fullName, string address, string city, string state, string zipCode, string country, string dateOfBirth) 
        : base(username, password, email, phoneNumber, fullName, address, city, state, zipCode, country, dateOfBirth)
    {

    }

    public void Buy()
    {

    }
    public void Sell()
    {

    }
    public void Post()
    {

    }
    public void DeletePost()
    {

    }
    public void Comment()
    {

    }
}