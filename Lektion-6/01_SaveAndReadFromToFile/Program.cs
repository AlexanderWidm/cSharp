/* Json = JavaScript Object Notation
    
    "key": "value" -pair

    {
        "firstName": "Alex",
        "lastName": "Widmark",
        "age": 28
        "isActive": false
        "skills": ["C#", "gym"],
        "relatives": [
            {"firstName": "Maja", "lastName": "Lund }
        ]
    }

*/



using _01_SaveAndReadFromToFile.Models;
using _01_SaveAndReadFromToFile.Services;

var customerService = new CustomerService();
customerService.GetCustomers();

var customer = new Customer
{
    FirstName = "Alexander",
    LastName = "Widmark",
    Email = "alexander@domain.se"
};


customerService.AddToList(customer);

Console.ReadKey();