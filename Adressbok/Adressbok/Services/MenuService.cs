using Adressbok.Interfaces;
using Adressbok.Models;
using Newtonsoft.Json;

namespace Adressbok.Services;

public class MenuService
{
    private static readonly IContactService contactService = new ContactService();

    public static void MainMenu()
    {
        try
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\r\n  ___      _                   _           _    \r\n / _ \\    | |                 | |         | |   \r\n/ /_\\ \\ __| |_ __ ___  ___ ___| |__   ___ | | __\r\n|  _  |/ _` | '__/ _ \\/ __/ __| '_ \\ / _ \\| |/ /\r\n| | | | (_| | | |  __/\\__ \\__ \\ |_) | (_) |   < \r\n\\_| |_/\\__,_|_|  \\___||___/___/_.__/ \\___/|_|\\_\\\r\n                                                \r\n                                                \r\n");
                Console.WriteLine("\nVälj ett av alternativen nedan i menyn\n" +
                                  "[1] Skapa en ny kontakt \n" +
                                  "[2] Visa alla kontakter \n" +
                                  "[3] Visa en kontakt \n" +
                                  "[4] Ta bort en kontakt \n" +
                                  "[5] Ändra en kontakt \n" +
                                  "[Q] Avsluta programmet \n"); // main menu
                var inputFromUser = Console.ReadKey(true);  // inputs from user to navigate main menu
                Console.Clear();

                switch (inputFromUser.Key)
                {
                    case ConsoleKey.D1:
                        {
                            AddContactMenu(); // press 1 to call AddContactMenu method to add contact to list
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            ViewAllContactMenu(); // press 2 to call ViewAllContactMenu method to show all contacts in list
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            ViewOneContactMenu(); // press 3 to call ViewOneContactMenu method to search and view one contact in list
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            RemoveOneContactMenu(); // press 4 to call RemoveOneContactMenu method to search and find then remove one contact in list
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            EditContactMenu();
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            Environment.Exit(0); // press Q to exit the program
                            break;
                        }
                }
                Console.ReadKey();
            }
            while (true);
        }
        catch (Exception ex) { Console.WriteLine($"Ett fel inträffade: {ex.Message}"); }
    
    }
    public static void AddContactMenu() // menu method for adding contact to list
    {
        try
        {
            Console.WriteLine("Lägg till kontakt.");
            IContact contact = new Contact();

            Console.WriteLine("Fyll i information om kontakten"); // enter information
            Console.WriteLine("");
            Console.Write("Förnamn: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Efternamn: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Email: ");
            contact.Email = Console.ReadLine();
            Console.Write("Telefonnummer: ");
            contact.Phone = Console.ReadLine();

            contact.Address = new Address();
            Console.Write("Gatunamn: ");
            contact.Address.StreetName = Console.ReadLine();
            Console.Write("Gatunummer: ");
            contact.Address.StreetNumber = Console.ReadLine();
            Console.Write("Postnummer: ");
            contact.Address.PostalCode = Console.ReadLine();
            Console.Write("Stad: ");
            contact.Address.City = Console.ReadLine();
            Console.WriteLine("");

            contactService.AddContact(contact); // calls AddContact method to add property to list
            
            var json = JsonConvert.SerializeObject(contact);
            FileService.AppendToFile(JsonConvert.SerializeObject(json));

            Console.WriteLine("");
            Console.WriteLine("Kontakt tillagd! Klicka valfri knapp för att återgå till huvudmeny.");
        }
        catch (Exception ex) { Console.WriteLine($"Ett fel inträffade: {ex.Message}"); }

    }
    public static void ViewAllContactMenu()
    {
        try
        {
            Console.WriteLine("\r\n _   __            _        _    _            \r\n| | / /           | |      | |  | |           \r\n| |/ /  ___  _ __ | |_ __ _| | _| |_ ___ _ __ \r\n|    \\ / _ \\| '_ \\| __/ _` | |/ / __/ _ \\ '__|\r\n| |\\  \\ (_) | | | | || (_| |   <| ||  __/ |   \r\n\\_| \\_/\\___/|_| |_|\\__\\__,_|_|\\_\\\\__\\___|_|   \r\n                                              \r\n                                              \r\n");

            var contacts = contactService.GetAllContacts();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Namn: {contact.FullName}");
                Console.WriteLine($" Email: <{contact.Email}>");
                Console.WriteLine($"Telefonnummer: {contact.Phone}");
                Console.WriteLine($"Adress: {contact.Address?.FullAddress}");
            }

            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri knapp för att återgå till huvudmenyn.");
        }
        catch (Exception ex) { Console.WriteLine($"Ett fel inträffade: {ex.Message}"); }
    }
    public static void ViewOneContactMenu() // menu method for finding and viewing one contact
    {
        try
        {

            Console.WriteLine("");
            Console.WriteLine("Sök på kontakt via e-postadress för att hitta kontakt.");

            Console.Write("E-postadress: "); // search by email
            var email = Console.ReadLine();
            var contact = contactService.GetOneContact(email!); // calls GetOneContact method. If input by user matches email in list, show contact

            if (contact != null) // check if contact is not null
            {
                Console.WriteLine($"Namn: {contact.FullName}");
                Console.WriteLine($"Email: <{contact.Email}>");
                Console.WriteLine($"Telefonnummer: {contact.Phone}");
                Console.WriteLine($"Adress: {contact.Address?.FullAddress}");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Kontakt med angiven e-postadress hittades inte.");
            }

            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri knapp för att återgå till huvudmenyn.");
        }
        catch (Exception ex) { Console.WriteLine($"Ett fel inträffade: {ex.Message}"); }
    }
    public static void RemoveOneContactMenu()
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("Sök på kontakt via e-postadress för ta bort kontakt.");

            Console.Write("E-postadress: "); // search by email
            var email = Console.ReadLine();

            Contact contactToRemove = (Contact)contactService.GetOneContact(email!);

            if (contactToRemove != null)
            {
                contactService.RemoveOneContact(email!); // calls RemoveOneContact method. If input by the user matches email in the list, find the contact and remove it from the list
                Console.WriteLine("Kontakten har tagits bort!");
            }
            else // if user input email that is 
            {
                Console.WriteLine("");
                Console.WriteLine("Kontakten med angiven e-postadress hittades inte. Inget att ta bort.");
            }

            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri knapp för att återgå till huvudmenyn.");
        }
        catch (Exception ex) { Console.WriteLine($"Ett fel inträffade: {ex.Message}"); }
    }
    public static void EditContactMenu()
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("Sök på kontakt via e-postadress för att ändra kontakt.");

            Console.Write("E-postadress: "); // Search by email
            var email = Console.ReadLine();

            IContact existingContact = contactService.GetOneContact(email!);

            if (existingContact != null)
            {
                Console.WriteLine("Här är den befintliga kontakten:");
                Console.WriteLine($"Namn: {existingContact.FullName}");
                Console.WriteLine($"Email: <{existingContact.Email}>");
                Console.WriteLine($"Telefonnummer: {existingContact.Phone}");
                Console.WriteLine($"Adress: {existingContact.Address?.FullAddress}");

                // Now, allow the user to update the contact's information
                Console.WriteLine("\nUppdatera kontaktinformation (lämna tomt för att behålla befintlig information):");
                Console.Write("Förnamn: ");
                string? newFirstName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFirstName))
                {
                    existingContact.FirstName = newFirstName;
                }

                Console.Write("Efternamn: ");
                string? newLastName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newLastName))
                {
                    existingContact.LastName = newLastName;
                }

                Console.Write("Ny Email: ");
                string? newEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newEmail))
                {
                    existingContact.Email = newEmail;
                }

                Console.Write("Nytt Telefonnummer: ");
                string? newPhone = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newPhone))
                {
                    existingContact.Phone = newPhone;
                }

                if (existingContact.Address != null)
                {
                    Console.Write("Nytt Gatunamn: ");
                    string? newStreetName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newStreetName))
                    {
                        existingContact.Address.StreetName = newStreetName;
                    }

                    Console.Write("Nytt Gatunummer: ");
                    string? newStreetNumber = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newStreetNumber))
                    {
                        existingContact.Address.StreetNumber = newStreetNumber;
                    }

                    Console.Write("Nytt Postnummer: ");
                    string? newPostalCode = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newPostalCode))
                    {
                        existingContact.Address.PostalCode = newPostalCode;
                    }

                    Console.Write("Ny Stad: ");
                    string? newCity = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newCity))
                    {
                        existingContact.Address.City = newCity;
                    }
                }

                Console.WriteLine("\nKontakten har uppdaterats!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Kontakten med angiven e-postadress hittades inte. Ingen ändring utförd.");
            }

            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri knapp för att återgå till huvudmenyn.");
        }
        catch (Exception ex) { Console.WriteLine($"Ett fel inträffade: {ex.Message}"); }
    }
}
