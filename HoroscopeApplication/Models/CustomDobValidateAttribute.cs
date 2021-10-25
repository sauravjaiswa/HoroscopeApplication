using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class CustomDobValidateAttribute : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateOfBirth = Convert.ToDateTime(value);

            if(dateOfBirth <= DateTime.Now)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Please enter valid Date of Birth");
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-dob", "Please enter valid Date of Birth");
        }
    }
}
