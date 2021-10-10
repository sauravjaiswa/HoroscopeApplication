using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public interface ISunsignRepository
    {
        Task<string> GetSunsign(string date);
        Task MapDates();
    }
}
