using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class CustomDobValidateAttribute : ValidationAttribute
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
    }
}
