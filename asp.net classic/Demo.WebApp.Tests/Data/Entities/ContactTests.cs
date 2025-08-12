using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.WebApp.Data.Entities;

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
                MainPhone = "123-456-7890"
            };

            Assert.AreEqual("John", contact.FirstName);
            Assert.AreEqual("Doe", contact.LastName);
            Assert.AreEqual("john.doe@example.com", contact.Email);
            Assert.AreEqual("123-456-7890", contact.MainPhone);
        }

        [TestMethod]
        public void CanSetAndGet_AlternatePhone()
        {
            var contact = new Contact
            {
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                MainPhone = "111-222-3333",
                AlternatePhone = "444-555-6666"
            };

            Assert.AreEqual("444-555-6666", contact.AlternatePhone);
        }

        [TestMethod]
        public void AlternatePhone_CanBeNullOrEmpty()
        {
            var contact = new Contact
            {
                FirstName = "Sam",
                LastName = "Adams",
                Email = "sam.adams@example.com",
                MainPhone = "222-333-4444",
                AlternatePhone = null
            };

            Assert.IsNull(contact.AlternatePhone);

            contact.AlternatePhone = string.Empty;
            Assert.AreEqual(string.Empty, contact.AlternatePhone);
        }
    }
}
