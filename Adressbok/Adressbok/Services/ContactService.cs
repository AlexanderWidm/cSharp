using Adressbok.Interfaces;
using System.Diagnostics;

namespace Adressbok.Services;

public class ContactService : IContactService
{
    private List<IContact> _contacts = new List<IContact>(); // creates list for contacts

    public ContactService()
    {
        _contacts = FileService.LoadContactsFromFile();
    }

    public void AddContact(IContact contact) // method for adding the object "Contact" to list
    {
        try
        {
            _contacts.Add(contact); // adds contact to list
            FileService.SaveContactsToFile(_contacts);
        }
        catch (Exception ex ) { Debug.WriteLine(ex); }
    }

    public IEnumerable<IContact> GetAllContacts() // method for getting all contacts in list
    {
        try
        {
                return _contacts;          
        }
        catch (Exception ex) { Debug.WriteLine(ex); }
        
        return null!;
    }

    public IContact GetOneContact(string email) // method to find one single contact in list with email
    {
        try
        {
            return _contacts.FirstOrDefault(x => x.Email == email)!; // if email input is the same as an email in list then return 
        }                                                           //that contact in list
        catch (Exception ex) { Debug.WriteLine(ex); }
        
        return null!;
    }

    public void RemoveOneContact(string email) // method to remove contact from the list with email
    {
        try
        {
            var contact = GetOneContact(email); // uses the GetOneContact to find contact in list with email
            _contacts.Remove(contact);  // removes that contact from list
            FileService.SaveContactsToFile(_contacts);
        }
        catch (Exception ex) { Debug.WriteLine(ex); }
    }
    public void EditContact(string email, IContact updatedContact) // method for updating contacts
    {
        try
        {
            var existingContact = GetOneContact(email); // gets contact by email with GetOneContact method

            if (existingContact.Address != null && updatedContact.Address != null)
            {
                // remove the existing contact from the list
                _contacts.Remove(existingContact);

                // update the properties of the existing contact with the new data
                existingContact.FirstName = updatedContact.FirstName;
                existingContact.LastName = updatedContact.LastName;
                existingContact.Email = updatedContact.Email;
                existingContact.Phone = updatedContact.Phone;
                existingContact.Address.StreetName = updatedContact.Address.StreetName;
                existingContact.Address.StreetNumber = updatedContact.Address.StreetNumber;
                existingContact.Address.PostalCode = updatedContact.Address.PostalCode;
                existingContact.Address.City = updatedContact.Address.City;

                // add the updated contact back to the list
                _contacts.Add(existingContact);
                FileService.SaveContactsToFile(_contacts);
            }
            else // if no contact with matching email was found
            {
                Console.WriteLine("Kontakten med angiven e-postadress hittades inte. Ingen ändring utförd.");
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex); }
    }
    
}
