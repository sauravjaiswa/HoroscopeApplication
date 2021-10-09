using HoroscopeApplication.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public interface IHoroscopeRepository
    {
        [Post("")]
        Task<Horoscope> GetHoroscope([Query] string sign, [Query] string day = "today");
    }
}
