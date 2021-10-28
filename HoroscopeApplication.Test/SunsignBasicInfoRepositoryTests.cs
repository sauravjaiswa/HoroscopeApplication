using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Test
{
    [TestClass]
    public class SunsignBasicInfoRepositoryTests
    {
        private void MapSunsignBasicInfo()
        {
            SunsignBasicInfoRepository.MapSunsignBasicInfo();
        }

        [TestMethod]
        public void Task_GetAllSunsigns_ReturnListOfSunsign()
        {
            List<string> sunsigns = Enum.GetNames(typeof(SunsignEnum)).ToList();
            //{ "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces" };
            var sunsignsToBeTested = SunsignBasicInfoRepository.GetAllSunsigns();

            Assert.IsNotNull(sunsignsToBeTested);
            CollectionAssert.AreEquivalent(sunsigns, sunsignsToBeTested);
            Assert.AreEqual(sunsigns.Count, sunsignsToBeTested.Count);
        }

        [TestMethod]
        public void Task_GetAllBasicInfo_ReturnCountZero()
        {
            var sunsignsBasicInfoToBeTested = SunsignBasicInfoRepository.GetAllBasicInfo();

            Assert.AreEqual(0, sunsignsBasicInfoToBeTested.Count);
        }

        [TestMethod]
        public void Task_GetAllBasicInfo_ReturnDictionarySunsignBasics()
        {
            MapSunsignBasicInfo();
            var sunsignsBasicInfoToBeTested = SunsignBasicInfoRepository.GetAllBasicInfo();

            Assert.IsNotNull(sunsignsBasicInfoToBeTested);
            Assert.AreEqual(12, sunsignsBasicInfoToBeTested.Count);
        }

        [TestMethod]
        public void Task_GetSunsignBasicInfo_ReturnSunsignBasicInfo()
        {
            string sign = SunsignEnum.Aries.ToString();
            var expected = new SunsignBasicInfo { DateRange = "March 21 – April 20", About = "Aries is the first sign of the Zodiac. It is associated with fresh vigor and new beginnings." };

            MapSunsignBasicInfo();
            var actual = SunsignBasicInfoRepository.GetSunsignBasicInfo(sign);

            Assert.IsInstanceOfType(actual, typeof(SunsignBasicInfo));
            Assert.IsTrue(ArePrivateObjectsAreEqual(expected, actual));
        }

        private static bool ArePrivateObjectsAreEqual(SunsignBasicInfo expected, SunsignBasicInfo actual)
        {
            return expected.DateRange == actual.DateRange &&
                    expected.About == actual.About;
        }
    }
}
