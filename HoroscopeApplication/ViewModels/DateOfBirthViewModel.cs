using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.ViewModels
{
    public class DateOfBirthViewModel
    {
        [Required]
        public DateTime Dob { get; set; }
    }
}
