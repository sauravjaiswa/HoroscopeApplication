using HoroscopeApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class History
    {
        public int Id { get; set; }
        public DateTime SearchedTimestamp { get; set; }
        public HoroscopeViewModel SearchedHoroscope { get; set; }
    }
}
