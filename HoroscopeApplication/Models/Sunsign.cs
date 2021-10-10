using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class Sunsign
    {
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string SunSign { get; set; }
    }
}
