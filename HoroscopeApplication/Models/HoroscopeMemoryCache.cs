using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class HoroscopeMemoryCache
    {
        [Required]
        public Horoscope Horoscope { get; set; }
        [Required]
        public DateTime AddedTimestamp { get; set; }
    }
}
