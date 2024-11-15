namespace elecTornHub_WPFBased.Classes;

public class Accounts
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public string? DateOfBirth { get; set; }

    public Accounts(){

    }

    public Accounts(string username, string password, string email, string phoneNumber, string fullName, string address, string city, string state, string zipCode, string country, string dateOfBirth)
    {
        Username = username;
        Password = password;
        Email = email;
        PhoneNumber = phoneNumber;
        FullName = fullName;
        Address = address;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
        DateOfBirth = dateOfBirth;
    }

    public void Register()
    {
        // Register the account
    }

    public void Login()
    {
        // Login the account
    }

    public void Logout()
    {
        // Logout the account
    }

}