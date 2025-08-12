using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.WebApp.Data.Entities;

namespace Demo.WebApp.Tests.Enums
{
    [TestClass]
    public class PhoneTypeEnumTests
    {
        [TestMethod]
        public void PhoneTypeEnum_HasMainAndAlternate()
        {
            Assert.IsTrue(Enum.IsDefined(typeof(PhoneTypeEnum), "main"));
            Assert.IsTrue(Enum.IsDefined(typeof(PhoneTypeEnum), "alternate"));
        }
    }
}
