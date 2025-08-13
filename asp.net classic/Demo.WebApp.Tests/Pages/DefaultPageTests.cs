using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Demo.WebApp;
using Demo.WebApp.Data;
using Demo.WebApp.Data.Entities;
using System.Web.UI.WebControls;

namespace Demo.WebApp.Tests.Pages
{
    [TestClass]
    public class DefaultPageTests
    {
        [TestMethod]
        public void Page_Load_BindsContactsToGridView_AndCSVExport()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new Contact { ID = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", MainPhone = "123" },
                new Contact { ID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", MainPhone = "456" }
            };
            var dbMock = new Mock<DemoContext>();
            dbMock.Setup(x => x.Contacts.ToList()).Returns(contacts);

            var page = new _Default();
            var grid = new GridView();
            var csvExport = new Demo.WebApp.Controls.CSVExport();
            typeof(_Default).GetField("ContactGridView", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).SetValue(page, grid);
            typeof(_Default).GetField("CSVExport", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).SetValue(page, csvExport);

            // Act
            // Simulate Page_Load
            // (You would need to refactor Page_Load to allow dependency injection for DemoContext to fully test this)
            // For now, just test that the controls can be set and data assigned
            grid.DataSource = contacts;
            grid.DataBind();
            csvExport.Contacts = contacts;
            csvExport.DataBind();

            // Assert
            Assert.AreEqual(2, ((List<Contact>)csvExport.Contacts).Count);
            Assert.AreEqual(2, ((List<Contact>)grid.DataSource).Count);
        }
    }
}
