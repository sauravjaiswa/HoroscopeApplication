using HoroscopeApplication.Models;
using HoroscopeApplication.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public class HoroscopeRepository : IHoroscopeRepository
    {
        private readonly IHoroscopeApiService _horoscopeApiService;
        private readonly HoroscopeAppDbContext _dbContext;

        public HoroscopeRepository(IHoroscopeApiService horoscopeApiService, 
                                    HoroscopeAppDbContext dbContext)
        {
            _horoscopeApiService = horoscopeApiService;
            _dbContext = dbContext;
        }
        public async Task<Horoscope> GetHoroscope(string sign)
        {
            var prevHoroscope = _dbContext.HoroscopeCaches.FirstOrDefault(h => h.Sunsign.ToLower() == sign.ToLower());

            Horoscope horoscopeModel = null;
            if (prevHoroscope != null)
            {
                var currDate = DateTime.Now.Date;
                var prevDate = prevHoroscope.AddedTimestamp.Date;

                if (currDate > prevDate)
                {
                    horoscopeModel = await _horoscopeApiService.GetHoroscope(sign);
                    RemoveCacheEntry(prevHoroscope);

                    HoroscopeCache horoscopeCache = new HoroscopeCache
                    {
                        Sunsign = sign,
                        Color = horoscopeModel.Color,
                        Compatibility = horoscopeModel.Compatibility,
                        Current_date = horoscopeModel.Current_date,
                        Date_range = horoscopeModel.Date_range,
                        Description = horoscopeModel.Description,
                        Lucky_number = horoscopeModel.Lucky_number,
                        Lucky_time = horoscopeModel.Lucky_time,
                        Mood = horoscopeModel.Mood,
                        AddedTimestamp = DateTime.Now
                    };
                    await AddCacheEntry(horoscopeCache);
                }
                else
                {
                    horoscopeModel = new Horoscope
                    {
                        Color = prevHoroscope.Color,
                        Compatibility = prevHoroscope.Compatibility,
                        Current_date = prevHoroscope.Current_date,
                        Date_range = prevHoroscope.Date_range,
                        Description = prevHoroscope.Description,
                        Lucky_number = prevHoroscope.Lucky_number,
                        Lucky_time = prevHoroscope.Lucky_time,
                        Mood = prevHoroscope.Mood
                    };
                }
            }
            else
            {
                horoscopeModel = await _horoscopeApiService.GetHoroscope(sign);
                //_dbContext.HoroscopeCaches.Remove(prevHoroscope);

                HoroscopeCache horoscopeCache = new HoroscopeCache
                {
                    Sunsign = sign,
                    Color = horoscopeModel.Color,
                    Compatibility = horoscopeModel.Compatibility,
                    Current_date = horoscopeModel.Current_date,
                    Date_range = horoscopeModel.Date_range,
                    Description = horoscopeModel.Description,
                    Lucky_number = horoscopeModel.Lucky_number,
                    Lucky_time = horoscopeModel.Lucky_time,
                    Mood = horoscopeModel.Mood,
                    AddedTimestamp = DateTime.Now
                };
                await AddCacheEntry(horoscopeCache);
            }

            return horoscopeModel;
        }

        public async Task AddCacheEntry(HoroscopeCache horoscopeCache)
        {
            await _dbContext.HoroscopeCaches.AddAsync(horoscopeCache);
            await _dbContext.SaveChangesAsync();
        }

        public void RemoveCacheEntry(HoroscopeCache horoscopeCache)
        {
            _dbContext.HoroscopeCaches.Remove(horoscopeCache);
        }
    }
}
