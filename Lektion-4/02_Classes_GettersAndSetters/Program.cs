using _02_Classes_GettersAndSetters.Models;
using System.Text;

var customer = new Customer();

// set - sätt ett värde
customer.FirstName = "Alexander ";
customer.LastName = "Widmark";

// get - hämta ett värde
var firstName = customer.FullName;


var user = new User();
user.FirstName = "Alexander";
user.LastName = "Widmark";
user.Email = "Widmark.alexander@gmail.com";
user.SetSecurePassword("HalliHallå123");

var password = Encoding.UTF8.GetString(user.Password);
Console.WriteLine($"Password: {password}");