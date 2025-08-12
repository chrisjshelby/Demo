using Demo.WebApp.Validators.PhoneNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.WebApp.Data.Entities
{
    public class Contact_Phone
    {
        public int ID { get; set; }

        public int ContactID { get; set; }

        [RequiredIfMainAttribute(nameof(PhoneType))]
        public string PhoneNumber { get; set; }

        [Required]
        public PhoneTypeEnum PhoneType { get; set; } // Enum Default: main
    }
}