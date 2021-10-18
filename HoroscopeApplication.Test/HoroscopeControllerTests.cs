using HoroscopeApplication.Controllers;
using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using HoroscopeApplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private ISunsignRepository _sunsignRepository;
        private IHoroscopeRepository _horoscopeRepository;
        private HoroscopeController _horoscopeController;

        [TestInitialize]
        public async Task Setup()
        {
            var configuration = new ConfigurationBuilder().AddUserSecrets<HoroscopeControllerTests>()
            .Build();

            string connectionString = configuration.GetConnectionString("HoroscopeClientDBConnection");
            DbContextOptions<HoroscopeAppDbContext> dbContextOptions = new DbContextOptionsBuilder<HoroscopeAppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            var context = new HoroscopeAppDbContext(dbContextOptions);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(configuration["AztroApi:BaseAddress"]);
            client.DefaultRequestHeaders.Add("x-rapidapi-host", configuration["AztroApi:Host"]);
            client.DefaultRequestHeaders.Add("x-rapidapi-key", configuration["AztroApi:ApiKey"]);

            var api = RestService.For<IHoroscopeApiService>(client);

            _sunsignRepository = new SunsignRepository(context);
            _horoscopeRepository = new HoroscopeRepository(api, context);

            _horoscopeController = new HoroscopeController(_sunsignRepository, _horoscopeRepository);

            await _sunsignRepository.MapDates();
        }

        [TestMethod]
        public async Task Task_DateOfBirth_ReturnActionResult()
        {
            DateOfBirthViewModel dateOfBirthViewModel = new DateOfBirthViewModel
            {
                Dob = DateTime.UtcNow,
                SunsignBasicInfos = SunsignBasicInfoRepository.GetAllBasicInfo()
            };

            var result = _horoscopeController.Index(dateOfBirthViewModel);

            Assert.IsNotNull(result);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _sunsignRepository = null;
            _horoscopeRepository = null;
            _horoscopeController = null;
        }
    }
}
