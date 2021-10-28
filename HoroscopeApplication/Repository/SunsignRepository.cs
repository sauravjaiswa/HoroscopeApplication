using HoroscopeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public class SunsignRepository : ISunsignRepository
    {
        private readonly HoroscopeAppDbContext _dbContext;

        public SunsignRepository(HoroscopeAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> GetSunsign(string date)
        {
            string sunsign = _dbContext.Sunsigns.FirstOrDefault(s => s.Date == date).SunSign;

            return sunsign;
        }

        public async Task MapDates()
        {
            if (_dbContext.Sunsigns.Count() == 0)
            {
                DateTime date, start, end;
                string sign = "";
                start = DateTime.Parse("01-01-2020");
                end = DateTime.Parse("31-12-2020");

                for (date = start; date <= end; date = date.AddDays(1))
                {
                    if (date >= DateTime.Parse("01-01-2020") && date <= DateTime.Parse("19-01-2020"))
                    {
                        sign = SunsignEnum.Capricorn.ToString();
                    }
                    else if (date >= DateTime.Parse("20-01-2020") && date <= DateTime.Parse("18-02-2020"))
                    {
                        sign = SunsignEnum.Aquarius.ToString();
                    }
                    else if (date >= DateTime.Parse("19-02-2020") && date <= DateTime.Parse("20-03-2020"))
                    {
                        sign = SunsignEnum.Pisces.ToString();
                    }
                    else if (date >= DateTime.Parse("21-03-2020") && date <= DateTime.Parse("19-04-2020"))
                    {
                        sign = SunsignEnum.Aries.ToString();
                    }
                    else if (date >= DateTime.Parse("20-04-2020") && date <= DateTime.Parse("20-05-2020"))
                    {
                        sign = SunsignEnum.Taurus.ToString();
                    }
                    else if (date >= DateTime.Parse("21-05-2020") && date <= DateTime.Parse("20-06-2020"))
                    {
                        sign = SunsignEnum.Gemini.ToString();
                    }
                    else if (date >= DateTime.Parse("21-06-2020") && date <= DateTime.Parse("22-07-2020"))
                    {
                        sign = SunsignEnum.Cancer.ToString();
                    }
                    else if (date >= DateTime.Parse("23-07-2020") && date <= DateTime.Parse("22-08-2020"))
                    {
                        sign = SunsignEnum.Leo.ToString();
                    }
                    else if (date >= DateTime.Parse("23-08-2020") && date <= DateTime.Parse("22-09-2020"))
                    {
                        sign = SunsignEnum.Virgo.ToString();
                    }
                    else if (date >= DateTime.Parse("23-09-2020") && date <= DateTime.Parse("22-10-2020"))
                    {
                        sign = SunsignEnum.Libra.ToString();
                    }
                    else if (date >= DateTime.Parse("23-10-2020") && date <= DateTime.Parse("21-11-2020"))
                    {
                        sign = SunsignEnum.Scorpio.ToString();
                    }
                    else if (date >= DateTime.Parse("22-11-2020") && date <= DateTime.Parse("21-12-2020"))
                    {
                        sign = SunsignEnum.Sagittarius.ToString();
                    }
                    else if (date >= DateTime.Parse("22-12-2020") && date <= DateTime.Parse("31-12-2020"))
                    {
                        sign = SunsignEnum.Capricorn.ToString();
                    }

                    string dateTemp = date.ToString();
                    string dateKey = dateTemp.Substring(0, dateTemp.LastIndexOf("-"));

                    await _dbContext.Sunsigns.AddAsync(new Sunsign { Date = dateKey, SunSign = sign });
                }

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
