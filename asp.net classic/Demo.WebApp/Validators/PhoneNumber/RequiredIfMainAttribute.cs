using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.WebApp.Validators.PhoneNumber
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredIfMainAttribute : ValidationAttribute
    {
        private readonly string _phoneTypeProperty;
        private readonly string _errorMsg;

        public RequiredIfMainAttribute(string phoneTypeProperty, string ErrorMessage = "Main phone number is required.")
        {
            _phoneTypeProperty = phoneTypeProperty;
            _errorMsg = ErrorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var phoneTypePropertyInfo = validationContext.ObjectType.GetProperty(_phoneTypeProperty);
            if (phoneTypePropertyInfo == null)
            {
                return new ValidationResult($"Unknown property: {_phoneTypeProperty}");
            }
            var phoneTypeValue = phoneTypePropertyInfo.GetValue(validationContext.ObjectInstance, null);
            if (phoneTypeValue != null && phoneTypeValue.ToString() == "main")
            {
                if (string.IsNullOrWhiteSpace(value as string))
                {
                    return new ValidationResult(_errorMsg);
                }
            }
            return ValidationResult.Success;
        }
    }
}