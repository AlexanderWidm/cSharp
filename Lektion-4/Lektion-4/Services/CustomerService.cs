using _01_Classes.Models;

namespace _01_Classes.Services;

internal class CustomerService
{
    // service = 90% Methods
    
    // _fields

    private List<Customer> _customerList;

    // Constructors

    //  Properties

    // Methods(propertyName)

    public void CreateCustomer(Customer customer) 
    {
        if (!_customerList.Contains(customer))
        {
            _customerList.Add(customer);
        }
    }

    public List<Customer> GetCustomer() 
    {
        return _customerList;
    }
    public void GetCustomers() { }
    public void UpdateCustomer() { }
    public void DeleteCustomer() { }

}
