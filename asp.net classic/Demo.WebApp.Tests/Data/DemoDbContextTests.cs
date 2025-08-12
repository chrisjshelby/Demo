using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.WebApp.Data;
using Demo.WebApp.Data.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Demo.WebApp.Tests.Data
{
    [TestClass]
    public class DemoDbContextTests
    {
        [TestMethod]
        public void CanInstantiateDemoDbContext()
        {
            using (var context = new Demo.WebApp.Data.Demo())
            {
                Assert.IsNotNull(context.Contacts);
                Assert.IsNotNull(context.Contact_Phones);
            }
        }
    }
}
