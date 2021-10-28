using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoroscopeApplication.Test
{
    [TestClass]
    public class HoroscopeRepositoryTests
    {
        private readonly Mock<IHoroscopeApiService> _mockApiService = new Mock<IHoroscopeApiService>();
        private readonly HoroscopeRepository _horoscopeRepository;

        public HoroscopeRepositoryTests()
        {
            _horoscopeRepository = new HoroscopeRepository(_mockApiService.Object);
        }

        [TestMethod]
        public async Task Task_GetHoroschope_ReturnHoroscope()
        {
            Horoscope horoscope = new Horoscope
            {
                Color = "Blue",
                Compatibility = "Taurus",
                Current_date = "September 24, 2020",
                Date_range = "Jan 20 - Feb 18",
                Description = "Your busy lifestyle has been fun, but today it's time to slow down and just relax.",
                Lucky_number = "93",
                Lucky_time = "6pm",
                Mood = "Relieved"
            };

            string sign = "aries";
            _mockApiService.Setup(a => a.GetHoroscope(sign, "today"))
                .ReturnsAsync(horoscope);

            var receivedHoroscope = await _horoscopeRepository.GetHoroscope(sign);

            Assert.IsNotNull(receivedHoroscope);
            Assert.AreEqual(horoscope.Date_range, receivedHoroscope.Date_range);
        }
    }
}
