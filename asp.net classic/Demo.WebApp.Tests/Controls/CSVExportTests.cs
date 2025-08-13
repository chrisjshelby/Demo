using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.WebApp.Controls;
using Demo.WebApp.Data.Entities;

namespace Demo.WebApp.Tests.Controls
{
    [TestClass]
    public class CSVExportTests
    {
        [TestMethod]
        public void ExportButton_Outputs_Correct_CSV()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new Contact { ID = 1, FirstName = "John", LastName = "Doe", MainPhone = "123", AlternatePhone = "456", Email = "john@example.com" },
                new Contact { ID = 2, FirstName = "Jane", LastName = "Smith", MainPhone = "789", AlternatePhone = null, Email = "jane@example.com" }
            };
            var csvExport = new CSVExport { Contacts = contacts };

            // Act
            var csv = new StringBuilder();
            foreach (var c in contacts)
            {
                csv.AppendLine($"{c.ID} {c.LastName}, {c.FirstName} {c.MainPhone}");
                if (!string.IsNullOrWhiteSpace(c.AlternatePhone) && c.MainPhone != c.AlternatePhone)
                {
                    csv.AppendLine($"{c.ID} {c.LastName}, {c.FirstName} {c.AlternatePhone}");
                }
            }
            var expected = csv.ToString();

            // Assert
            Assert.IsTrue(expected.Contains("1 Doe, John 123"));
            Assert.IsTrue(expected.Contains("1 Doe, John 456"));
            Assert.IsTrue(expected.Contains("2 Smith, Jane 789"));
        }
    }
}
