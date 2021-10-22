using HoroscopeApplication.Controllers;
using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using HoroscopeApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HoroscopeApplication.Test
{
    [TestClass]
    public class HoroscopeControllerTests
    {
        private readonly Mock<ISunsignRepository> _sunsignRepository = new Mock<ISunsignRepository>();
        private readonly Mock<IHoroscopeRepository> _horoscopeRepository = new Mock<IHoroscopeRepository>();
        private readonly HoroscopeController _horoscopeController;

        public HoroscopeControllerTests()
        {
            _horoscopeController = new HoroscopeController(_sunsignRepository.Object, _horoscopeRepository.Object);
        }

        [TestMethod]
        public async Task Task_DateOfBirth_ReturnActionResult()
        {
            string date = "01-01";
            string sunsign = "Aries";
            var horoscope = new Horoscope
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

            string sign = "Aries";

            DateOfBirthViewModel dateOfBirthViewModel = new DateOfBirthViewModel
            {
                Dob = DateTime.UtcNow,
                SunsignBasicInfos = SunsignBasicInfoRepository.GetAllBasicInfo()
            };


            _sunsignRepository.Setup(s => s.MapDates());
            _sunsignRepository.Setup(s => s.GetSunsign(date))
                .ReturnsAsync(sign);

            _horoscopeRepository.Setup(h => h.GetHoroscope(sunsign))
                .ReturnsAsync(horoscope);

            var result = _horoscopeController.Index(dateOfBirthViewModel);
            
            Assert.IsNotNull(result);
        }
    }
}
