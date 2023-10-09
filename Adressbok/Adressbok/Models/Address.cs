using Adressbok.Interfaces;

namespace Adressbok.Models;

public class Address : IAddress
{
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? StreetName { get; set; }
    public string? StreetNumber { get; set; }

    public string? FullAddress => $"{StreetName} {StreetNumber} {PostalCode} {City}";
}
