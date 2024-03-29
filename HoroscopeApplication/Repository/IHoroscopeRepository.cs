﻿using HoroscopeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public interface IHoroscopeRepository
    {
        Task<Horoscope> GetHoroscope(string sign);
    }
}
