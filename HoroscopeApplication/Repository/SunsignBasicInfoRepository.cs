using HoroscopeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Repository
{
    public static class SunsignBasicInfoRepository
    {
        private static readonly Dictionary<string, SunsignBasicInfo> _sunsignInfo = new Dictionary<string, SunsignBasicInfo>();
        private static string[] sunsigns = { "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces" };

        public static void MapSunsignBasicInfo()
        {
            if (_sunsignInfo.Count() == 0)
            {
                _sunsignInfo.Add(sunsigns[0], new SunsignBasicInfo { DateRange = "March 21 – April 19", About = "Aries is the first sign of the Zodiac. It is associated with fresh vigor and new beginnings." });
                _sunsignInfo.Add(sunsigns[1], new SunsignBasicInfo { DateRange = "April 20 – May 20", About = "Taurus is the second sign of the Zodiac and is associated with material pleasure." });
                _sunsignInfo.Add(sunsigns[2], new SunsignBasicInfo { DateRange = "May 21 – June 20", About = "Gemini is the third sign of the Zodiac and is associated with youth and versatility." });
                _sunsignInfo.Add(sunsigns[3], new SunsignBasicInfo { DateRange = "June 22 – July 22", About = "Cancer is the fourth sign of the Zodiac. It is associated with family and domesticity." });
                _sunsignInfo.Add(sunsigns[4], new SunsignBasicInfo { DateRange = "July 23 – August 22", About = "Leo is the fifth sign of the Zodiac and is associated with the keywords magnanimous, generous, hospitable, caring, warm, authoritative, active, and open." });
                _sunsignInfo.Add(sunsigns[5], new SunsignBasicInfo { DateRange = "August 23 – September 22", About = "Virgo is the sixth sign of the Zodiac. It is associated with purity and service." });
                _sunsignInfo.Add(sunsigns[6], new SunsignBasicInfo { DateRange = "September 23 – October 22", About = "Libra is the seventh sign of the Zodiac. It is associated with justice." });
                _sunsignInfo.Add(sunsigns[7], new SunsignBasicInfo { DateRange = "October 23 – November 21", About = "Scorpio is the eighth sign of the Zodiac. It is associated with intensity, passion, and power." });
                _sunsignInfo.Add(sunsigns[8], new SunsignBasicInfo { DateRange = "November 22 – December 21", About = "Sagittarius is the ninth sign of the Zodiac. It is associated with travel and expansion." });
                _sunsignInfo.Add(sunsigns[9], new SunsignBasicInfo { DateRange = "December 22 – January 19", About = "Capricorn is the 10th sign of the Zodiac and is associated with hard work and business affairs." });
                _sunsignInfo.Add(sunsigns[10], new SunsignBasicInfo { DateRange = "January 20 – February 18", About = "Aquarius is the 11th sign of the Zodiac and is associated with future ideas and the unusual." });
                _sunsignInfo.Add(sunsigns[11], new SunsignBasicInfo { DateRange = "February 19 – March 20", About = "Pisces is the 12th and last sign of the Zodiac and is associated with human emotions." });
            }
        }

        public static SunsignBasicInfo GetSunsignBasicInfo(string sign)
        {
            if (_sunsignInfo.ContainsKey(sign))
            {
                return _sunsignInfo.GetValueOrDefault(sign);
            }

            return null;
        }

        public static string[] GetAllSunsigns()
        {
            return sunsigns;
        }

        public static Dictionary<string, SunsignBasicInfo> GetAllBasicInfo()
        {
            return _sunsignInfo;
        }
    }
}
