using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoroscopeApplication.Test
{
    [TestClass]
    public class SunsignRepositoryTests
    {
        private ISunsignRepository _sunsignRepository;

        [TestInitialize]
        public async Task Setup()
        {
            var configuration = new ConfigurationBuilder().AddUserSecrets<SunsignBasicInfoRepositoryTests>()
            .Build();

            string connectionString = configuration.GetConnectionString("HoroscopeClientDBConnection");
            DbContextOptions<HoroscopeAppDbContext> dbContextOptions = new DbContextOptionsBuilder<HoroscopeAppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            var context = new HoroscopeAppDbContext(dbContextOptions);

            _sunsignRepository = new SunsignRepository(context);

            await _sunsignRepository.MapDates();
        }

        [TestMethod]
        public async Task Task_GetSunsign_ReturnSunsign()
        {
            string date = "01-01";
            string expectedSunsign = "Capricorn";

            var actualSunsign = await _sunsignRepository.GetSunsign(date);

            Assert.IsNotNull(actualSunsign);
            Assert.AreEqual(expectedSunsign, actualSunsign);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _sunsignRepository = null;
        }
    }
}
