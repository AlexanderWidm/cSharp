using _03_ClassesConstructors.Models;

var customer_1 = new Customer();
customer_1.Id = 1;
customer_1.Name = "Alexander Widmark";
customer_1.Email = "widmark.alexander@gmail.com";
customer_1.PhoneNumber = "1234567890";

var customer_2 = new Customer()
{
    Id = 1,
    Name = "Alexander Widmark",
    Email = "widmark.alexander@gmail.com",
    PhoneNumber = "1234567890"
};

var customer_3 = new Customer("Alexander Widmark", "widmark.alexander@gmail.com");

var customer_4 = new Customer();