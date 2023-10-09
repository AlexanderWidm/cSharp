namespace _03_ClassesConstructors.Models;

internal class Customer
{
    public Customer()
    {
        Name = "";
        Email = "";
        PhoneNumber = "";
    }
    public Customer(string name)
    {
        Name = name;
        Email = "";
        PhoneNumber = "";
    }
    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
        PhoneNumber = "";
    }
    public Customer(string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}
