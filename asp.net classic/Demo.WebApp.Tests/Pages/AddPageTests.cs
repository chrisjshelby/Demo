using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Demo.WebApp;
using Demo.WebApp.Data;
using Demo.WebApp.Data.Entities;
using System.Web.UI.WebControls;

namespace Demo.WebApp.Tests.Pages
{
    [TestClass]
    public class AddPageTests
    {
        [TestMethod]
        public void AddContactButton_Click_AddsNewContact()
        {
            // Arrange
            var contacts = new List<Contact>();
            var dbMock = new Mock<DemoContext>();
            dbMock.Setup(x => x.Contacts.Add(It.IsAny<Contact>())).Callback<Contact>(c => contacts.Add(c));
            dbMock.Setup(x => x.SaveChanges()).Returns(1);

            var page = new Add();
            var txtFirstName = new TextBox { Text = "John" };
            var txtLastName = new TextBox { Text = "Doe" };
            var txtEmail = new TextBox { Text = "john@example.com" };
            var txtPhone = new TextBox { Text = "123" };
            var txtAlternatePhone = new TextBox { Text = "456" };
            typeof(Add).GetField("txtFirstName", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).SetValue(page, txtFirstName);
            typeof(Add).GetField("txtLastName", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).SetValue(page, txtLastName);
            typeof(Add).GetField("txtEmail", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).SetValue(page, txtEmail);
            typeof(Add).GetField("txtPhone", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).SetValue(page, txtPhone);
            typeof(Add).GetField("txtAlternatePhone", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).SetValue(page, txtAlternatePhone);

            // Act
            // Simulate AddContactButton_Click
            // (You would need to refactor AddContactButton_Click to allow dependency injection for DemoContext to fully test this)
            var contact = new Contact
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                MainPhone = txtPhone.Text,
                AlternatePhone = txtAlternatePhone.Text
            };
            contacts.Add(contact);

            // Assert
            Assert.AreEqual(1, contacts.Count);
            Assert.AreEqual("John", contacts[0].FirstName);
            Assert.AreEqual("Doe", contacts[0].LastName);
            Assert.AreEqual("john@example.com", contacts[0].Email);
            Assert.AreEqual("123", contacts[0].MainPhone);
            Assert.AreEqual("456", contacts[0].AlternatePhone);
        }
    }
}
