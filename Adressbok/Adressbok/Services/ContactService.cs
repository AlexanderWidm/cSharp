using Adressbok.Interfaces;

namespace Adressbok.Services;

public class ContactService : IContactService
{
    private List<IContact> _contacts = new List<IContact>(); // creates list for contacts

    public void AddContact(IContact contact) // method for adding the object "Contact" to list
    {

        _contacts.Add(contact); // adds contact to list
    }

    public IEnumerable<IContact> GetAllContacts() // method for getting all contacts in list
    {
        {
            return _contacts;
        }
    }

    public IContact GetOneContact(string email) // method to find one single contact in list with email
    {
        return _contacts.FirstOrDefault(x => x.Email == email)!; // if email input is the same as an email in list then return 
                                                                 //that contact in list
    }

    public void RemoveOneContact(string email) // method to remove contact from the list with email
    {
        var contact = GetOneContact(email); // uses the GetOneContact to find contact in list with email
        _contacts.Remove(contact);  // removes that contact from list
    }
    public void EditContact(string email, IContact updatedContact) // method for updating contacts
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
        }
        else // if no contact with matching email was found
        {
            Console.WriteLine("Kontakten med angiven e-postadress hittades inte. Ingen ändring utförd.");
        }
    }
}
