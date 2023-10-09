/* Namngivining av klasser: 

- Customer, User, Product, Order, Case, Machine, Device

- CustomerRequests, UserRequests, ProductRequests

- CustomerResponse, UserResponse, ProductResponse

- CreateCustomer, CreateUser, CreateProduct

- CustomerCreate, UserCreate, ProductCreate


DET SKA VARA LOGISKT!

Suffix t.ex. "Customer"

Request - När du skickar in något till systemet (data från reg.formulär)
Schema - När du skickar in något till systemet (baseras på Swagger)

Responsse - När du skickar något tillbaka från systemet (ex. en kund)
Model - När du skickar något tillbaka från systemet (baseras på MVC)
Customer - När du skickar något tillbaka från systemet (objektets typ)

Old people: CustomerDto, UserDto, ProductDto
Dto - Data Transfer Object och kan vara när du skickar till eller från ett system 
      mellan olika delar i ett system (lite odefinerat)

*/
using _01_Classes.Services;

/*  Access Modifiers
 -------------------------------------------
    private     accessbara bara inom scopet (dvs { }) som variabeln liiger inom
    public      accessbar överallt i hela din solution, dvs även mellan olika projekt
    internal    accessbar i hela ditt projekt, men inte mellan olika projekt 

*/


// Vi gör en instans av en customerService
// så vi kan använda den
var customerService = new CustomerService();

customerService.GetCustomer();

