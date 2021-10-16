using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class SunsignBasicInfo
    {
        [Required]
        public string DateRange { get; set; }
        [Required]
        public string About { get; set; }
    }
}
