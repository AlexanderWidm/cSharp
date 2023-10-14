namespace Adressbok.Interfaces;

public interface IContactService
{
    void AddContact(IContact contact);
    IEnumerable<IContact> GetAllContacts();
    IContact GetOneContact(string email);
    void RemoveOneContact(string email);
}
