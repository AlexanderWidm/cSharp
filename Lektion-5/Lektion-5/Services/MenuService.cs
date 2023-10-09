using Lektion_5.Interfaces;
using Lektion_5.Models;

namespace Lektion_5.Services;

internal interface IMenuService
{
    public void MainMenu();
    public void CreateMenu();
    public void ListAllMenu();
    public void ListSpecificMenu();
}
internal class MenuService : IMenuService

{
    private readonly IUserService _userService = new UserService();
    public void MainMenu()
    {
        var exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Skapa ny användare");
            Console.WriteLine("2. Visa specifik användare");
            Console.WriteLine("3. Visa alla användare");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj ett av ovanstående alternativ (0-4):");
            var option = Console.ReadLine();
            
            switch(option)
            {
                case "1":
                    CreateMenu();
                    break;
                
                case "2":
                    ListSpecificMenu();
                    break;
                
                case "3":
                    ListAllMenu();
                    break;
                
                case "0":
                    exit = true;
                    break;
                
                default:
                    break;
            }
        }
        while (exit == false);
    }
    public void CreateMenu()

    {
        Console.Clear();
        Console.WriteLine("Skapa en ny användare");
        Console.WriteLine("---------------------");

        var user = new UserCreateRequest();
        Console.Write("Förnamn: ");
        user.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Efternamn: ");
        user.LastName = Console.ReadLine()!.Trim();

        Console.Write("E-postadress: ");
        user.Email = Console.ReadLine()!.Trim().ToLower();

        Console.Write("Lösenord: ");
        user.Password = Console.ReadLine()!.Trim();

        _userService.CreateUser(user);
        Console.WriteLine("En ny användare har lagts till.");
        Console.ReadKey();
    }

    public void ListAllMenu()
    {
        Console.Clear();
        Console.WriteLine("Alla användare");
        Console.WriteLine("---------------------");

        foreach (var user in _userService.GetUsers())       
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
       
        Console.ReadKey();
    }

        public void ListSpecificMenu()
    {
        Console.Clear();
        Console.WriteLine("Specifik användare");
        Console.WriteLine("---------------------");
        Console.Write("Ange e-postadress: ");
        var email = Console.ReadLine()!.Trim().ToLower();
        var user = _userService.GetUser(user => user.Email == email);

        if (user != null)
            Console.WriteLine($"{user.FirstName} {user.LastName} {user.Email}");
        else   
            Console.WriteLine($"Kunde inte hitta någon användare med e-postadressen {email}");
        
        Console.ReadKey();
    }
}
