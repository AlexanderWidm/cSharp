/*int x = 7;
int y = x + 3;

Console.WriteLine(y);
Console.ReadKey();
*/
Console.WriteLine("What is your name?");
Console.Write("Type your first name: ");
string myFirstName = Console.ReadLine();

Console.Write("Type in your last name: ");
string myLastName = Console.ReadLine();

Console.WriteLine($"Hello {myFirstName} {myLastName}."); 