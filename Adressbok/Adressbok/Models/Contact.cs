using Adressbok.Interfaces;

namespace Adressbok.Models;

public class Contact : IContact
{
    public IAddress? Address { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set;  }

    public string? FullName => $"{FirstName} {LastName}";
}
