using HoroscopeApplication.Models;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public class HoroscopeRepository : IHoroscopeRepository
    {
        private readonly IHoroscopeApiService _horoscopeApiService;

        public HoroscopeRepository(IHoroscopeApiService horoscopeApiService)
        {
            _horoscopeApiService = horoscopeApiService;
        }
        public async Task<Horoscope> GetHoroscope(string sign)
        {
            var horoscopeModel = await _horoscopeApiService.GetHoroscope(sign);

            return horoscopeModel;
        }
    }
}
