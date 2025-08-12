using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.WebApp.Data.Entities;
using System.Collections.Generic;

namespace Demo.WebApp.Tests.Data.Entities
{
    [TestClass]
    public class ContactTests
    {
        [TestMethod]
        public void CanCreateContact_WithRequiredFields()
        {
            var contact = new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phones = new List<Contact_Phone>()
            };

            Assert.AreEqual("John", contact.FirstName);
            Assert.AreEqual("Doe", contact.LastName);
            Assert.AreEqual("john.doe@example.com", contact.Email);
            Assert.IsNotNull(contact.Phones);
        }
    }
}
