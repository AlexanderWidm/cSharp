using Adressbok.Services;
using Adressbok.Models;

namespace Adressbok.Tests;

    public class ContactServiceTests
    {
        [Fact]
        public void AddContact_ContactIsAddedToList() // unit test to test AddContact method
        {
            // Arrange
            var contactService = new ContactService();
            var contact = new Contact
            {
                FirstName = "Alexander",
                LastName = "Widmark",
                Email = "widmark.alexander@gmail.com",
                Phone = "0732682790",
                Address = new Address
                {
                    StreetName = "Dragarbrunntsgatan",
                    StreetNumber = "58",
                    PostalCode = "75320",
                    City = "UPPSALA"
                }
            };

            // Act
            contactService.AddContact(contact);

            // Assert
            Assert.Contains(contact, contactService.GetAllContacts());
        }
    }
