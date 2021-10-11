using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class HoroscopeCache
    {
        public int Id { get; set; }
        [Required]
        public string Sunsign { get; set; }
        [Required]
        public string Color { get; set; }

        [Required]
        public string Compatibility { get; set; }

        [Required]
        public string Current_date { get; set; }

        [Required]
        public string Date_range { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Lucky_number { get; set; }

        [Required]
        public string Lucky_time { get; set; }

        [Required]
        public string Mood { get; set; }
        [Required]
        public DateTime AddedTimestamp { get; set; }
    }
}
