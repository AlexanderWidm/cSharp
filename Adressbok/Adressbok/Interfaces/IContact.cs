﻿namespace Adressbok.Interfaces;

public interface IContact
{
    IAddress? Address { get; set; }
    string? Email { get; set; }
    string? FirstName { get; set; }
    string? LastName { get; set; }
    string? FullName { get; }
    string? Phone { get; set; }
}
