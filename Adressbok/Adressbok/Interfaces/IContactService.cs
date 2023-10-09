namespace Adressbok.Interfaces;

public interface IContactService
{
    void AddContact(IContact contact);
    IEnumerable<IContact> GetContacts();
    IContact GetOneContact(string email);
    void RemoveOneCustomer(string email);
}
