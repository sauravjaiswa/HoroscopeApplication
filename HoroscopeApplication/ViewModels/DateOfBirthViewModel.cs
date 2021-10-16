using HoroscopeApplication.Models;
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
        [Required]
        public Dictionary<string, SunsignBasicInfo> SunsignBasicInfos { get; set; } = new Dictionary<string, SunsignBasicInfo>();
    }
}
