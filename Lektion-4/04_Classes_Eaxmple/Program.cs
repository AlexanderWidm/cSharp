using _04_Classes_Eaxmple.Models;

var customers = new List<Customer>();
var option = 0;

do
{
    var customer = new Customer();

    Console.Write("Namn: ");
    customer.Name = Console.ReadLine();

    Console.Write("Email: ");
    customer.Email = Console.ReadLine();

    Console.Write("Telefon: ");
    customer.PhoneNumber = Console.ReadLine();

    customers.Add(customer);

    var u = customers.SingleOrDefault(x => x.Name == customer.Name);
    Console.WriteLine(u.Name);

}
while (option == 0);