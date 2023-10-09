using Adressbok.Interfaces;

namespace Adressbok.Services;

public class ContactService : IContactService
{
    private List<IContact> _contacts = new List<IContact>();
    private readonly string _filePath = @"C:\Skola\C-Sharp\Adressbok";
    public void AddContact(IContact contact)
    {
        _contacts.Add(contact);
    }

    public IEnumerable<IContact> GetContacts()
    {
        return _contacts;
    }

    public IContact GetOneContact(string email)
    {
        return _contacts.FirstOrDefault(x => x.Email == email)!;
    }

    public void RemoveOneCustomer(string email)
    {
        var contact = GetOneContact(email);
        _contacts.Remove(contact);
    }
}
