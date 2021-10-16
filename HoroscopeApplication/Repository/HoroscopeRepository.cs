using HoroscopeApplication.Models;
using HoroscopeApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public class HoroscopeRepository : IHoroscopeRepository
    {
        private readonly IHoroscopeApiService _horoscopeApiService;
        private readonly HoroscopeAppDbContext _dbContext;

        private static readonly Dictionary<string, HoroscopeMemoryCache> _horoscopeCache = new Dictionary<string, HoroscopeMemoryCache>();

        public HoroscopeRepository(IHoroscopeApiService horoscopeApiService, 
                                    HoroscopeAppDbContext dbContext)
        {
            _horoscopeApiService = horoscopeApiService;
            _dbContext = dbContext;
        }

        /**Working on DB cache**/
        //public async Task<Horoscope> GetHoroscope(string sign)
        //{
        //    var prevHoroscope = _dbContext.HoroscopeCaches.FirstOrDefault(h => h.Sunsign.ToLower() == sign.ToLower());

        //    Horoscope horoscopeModel = null;
        //    if (prevHoroscope != null)
        //    {
        //        var currDate = DateTime.Now.Date;
        //        var prevDate = prevHoroscope.AddedTimestamp.Date;

        //        if (currDate > prevDate)
        //        {
        //            horoscopeModel = await _horoscopeApiService.GetHoroscope(sign);
        //            RemoveCacheEntry(prevHoroscope);

        //            HoroscopeCache horoscopeCache = new HoroscopeCache
        //            {
        //                Sunsign = sign,
        //                Color = horoscopeModel.Color,
        //                Compatibility = horoscopeModel.Compatibility,
        //                Current_date = horoscopeModel.Current_date,
        //                Date_range = horoscopeModel.Date_range,
        //                Description = horoscopeModel.Description,
        //                Lucky_number = horoscopeModel.Lucky_number,
        //                Lucky_time = horoscopeModel.Lucky_time,
        //                Mood = horoscopeModel.Mood,
        //                AddedTimestamp = DateTime.Now
        //            };
        //            await AddCacheEntry(horoscopeCache);
        //        }
        //        else
        //        {
        //            horoscopeModel = new Horoscope
        //            {
        //                Color = prevHoroscope.Color,
        //                Compatibility = prevHoroscope.Compatibility,
        //                Current_date = prevHoroscope.Current_date,
        //                Date_range = prevHoroscope.Date_range,
        //                Description = prevHoroscope.Description,
        //                Lucky_number = prevHoroscope.Lucky_number,
        //                Lucky_time = prevHoroscope.Lucky_time,
        //                Mood = prevHoroscope.Mood
        //            };
        //        }
        //    }
        //    else
        //    {
        //        horoscopeModel = await _horoscopeApiService.GetHoroscope(sign);
        //        //_dbContext.HoroscopeCaches.Remove(prevHoroscope);

        //        HoroscopeCache horoscopeCache = new HoroscopeCache
        //        {
        //            Sunsign = sign,
        //            Color = horoscopeModel.Color,
        //            Compatibility = horoscopeModel.Compatibility,
        //            Current_date = horoscopeModel.Current_date,
        //            Date_range = horoscopeModel.Date_range,
        //            Description = horoscopeModel.Description,
        //            Lucky_number = horoscopeModel.Lucky_number,
        //            Lucky_time = horoscopeModel.Lucky_time,
        //            Mood = horoscopeModel.Mood,
        //            AddedTimestamp = DateTime.Now
        //        };
        //        await AddCacheEntry(horoscopeCache);
        //    }

        //    return horoscopeModel;
        //}

        //public async Task AddCacheEntry(HoroscopeCache horoscopeCache)
        //{
        //    await _dbContext.HoroscopeCaches.AddAsync(horoscopeCache);
        //    await _dbContext.SaveChangesAsync();
        //}

        //public void RemoveCacheEntry(HoroscopeCache horoscopeCache)
        //{
        //    _dbContext.HoroscopeCaches.Remove(horoscopeCache);
        //}





        /**Working on In memory cache**/
        public async Task<Horoscope> GetHoroscope(string sign)
        {
            sign = sign.ToLower();
            var prevHoroscope = _horoscopeCache.GetValueOrDefault(sign);

            Horoscope horoscopeModel = null;
            if (prevHoroscope != null)
            {
                var currDate = DateTime.UtcNow.AddDays(1).Date;
                var prevDate = prevHoroscope.AddedTimestamp.Date;

                if (currDate > prevDate)
                {
                    horoscopeModel = await _horoscopeApiService.GetHoroscope(sign);
                    RemoveCacheEntry(sign);

                    HoroscopeMemoryCache horoscopeMemoryCache = new HoroscopeMemoryCache
                    {
                        Horoscope = horoscopeModel,
                        AddedTimestamp = DateTime.UtcNow
                    };
                    AddCacheEntry(sign, horoscopeMemoryCache);
                }
                else
                {
                    horoscopeModel = prevHoroscope.Horoscope;
                }
            }
            else
            {
                horoscopeModel = await _horoscopeApiService.GetHoroscope(sign);

                HoroscopeMemoryCache horoscopeMemoryCache = new HoroscopeMemoryCache
                {
                    Horoscope = horoscopeModel,
                    AddedTimestamp = DateTime.UtcNow
                };
                AddCacheEntry(sign, horoscopeMemoryCache);
            }

            return horoscopeModel;
        }

        private void AddCacheEntry(string sign, HoroscopeMemoryCache horoscopeMemoryCache)
        {
            if (!_horoscopeCache.ContainsKey(sign))
            {
                _horoscopeCache.Add(sign, horoscopeMemoryCache);
            }
        }

        private void RemoveCacheEntry(string sign)
        {
            if (_horoscopeCache.ContainsKey(sign))
            {
                _horoscopeCache.Remove(sign);
            }
        }
    }
}
