using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.WebApp.Data.Entities;

namespace Demo.WebApp.Tests.Data.Entities
{
    [TestClass]
    public class ContactPhoneTests
    {
        [TestMethod]
        public void CanCreateContactPhone_WithRequiredFields()
        {
            var phone = new Contact_Phone
            {
                ContactID = 1,
                PhoneNumber = "123-456-7890",
                PhoneType = PhoneTypeEnum.main
            };

            Assert.AreEqual(1, phone.ContactID);
            Assert.AreEqual("123-456-7890", phone.PhoneNumber);
            Assert.AreEqual(PhoneTypeEnum.main, phone.PhoneType);
        }

        [TestMethod]
        public void CanSetAndGet_AlternatePhoneType()
        {
            var phone = new Contact_Phone
            {
                ContactID = 2,
                PhoneNumber = "555-555-5555",
                PhoneType = PhoneTypeEnum.alternate
            };

            Assert.AreEqual(PhoneTypeEnum.alternate, phone.PhoneType);
        }

        [TestMethod]
        public void PhoneNumber_CanBeNullOrEmpty()
        {
            var phone = new Contact_Phone
            {
                ContactID = 3,
                PhoneNumber = null,
                PhoneType = PhoneTypeEnum.main
            };

            Assert.IsNull(phone.PhoneNumber);

            phone.PhoneNumber = string.Empty;
            Assert.AreEqual(string.Empty, phone.PhoneNumber);
        }

        [TestMethod]
        public void ContactID_DefaultsToZero()
        {
            var phone = new Contact_Phone();
            Assert.AreEqual(0, phone.ContactID);
        }
    }
}
