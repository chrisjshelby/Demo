using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.WebApp.Data;
using Demo.WebApp.Data.Entities;
using System.Data.Entity;

namespace Demo.WebApp.Tests.Data
{
    [TestClass]
    public class DemoContextTests
    {
        [TestMethod]
        public void CanInstantiateDemoContext_AndAccessContacts()
        {
            using (var context = new DemoContext())
            {
                Assert.IsNotNull(context.Contacts);
            }
        }
    }
}
