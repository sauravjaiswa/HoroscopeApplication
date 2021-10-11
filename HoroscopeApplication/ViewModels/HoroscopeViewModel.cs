using HoroscopeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.ViewModels
{
    public class HoroscopeViewModel
    {
        public string Sunsign { get; set; }
        public Horoscope Horoscope { get; set; }
    }
}
