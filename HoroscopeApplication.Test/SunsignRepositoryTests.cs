using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoroscopeApplication.Test
{
    [TestClass]
    public class SunsignRepositoryTests
    {
        private ISunsignRepository _sunsignRepository;

        //[TestInitialize]
        //public async Task Setup()
        //{
        //    var configuration = new ConfigurationBuilder().AddUserSecrets<SunsignRepositoryTests>()
        //    .Build();

        //    string connectionString = configuration.GetConnectionString("HoroscopeClientDBConnection");
        //    DbContextOptions<HoroscopeAppDbContext> dbContextOptions = new DbContextOptionsBuilder<HoroscopeAppDbContext>()
        //        .UseSqlServer(connectionString)
        //        .Options;

        //    var context = new HoroscopeAppDbContext(dbContextOptions);

        //    _sunsignRepository = new SunsignRepository(context);

        //    //await _sunsignRepository.MapDates();
        //}

        [TestMethod]
        public async Task Task_GetSunsign_ReturnSunsign()
        {
            //Arrange
            string expectedDate = "01-01";
            string expectedSunsign = SunsignEnum.Capricorn.ToString();

            DateTime date, start, end;
            string sign = "";
            start = DateTime.Parse("01-01-2020");
            end = DateTime.Parse("31-12-2020");
            int cnt = 1;

            List<Sunsign> dateToSunsignList = new List<Sunsign>();

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

                dateToSunsignList.Add(new Sunsign { Id = cnt, Date = dateKey, SunSign = sign });
                cnt++;
            }

            var data = dateToSunsignList.AsQueryable();

            var mockSet = new Mock<DbSet<Sunsign>>();
            var options = new DbContextOptionsBuilder<HoroscopeAppDbContext>()
                    .Options;

            mockSet.As<IQueryable<Sunsign>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Sunsign>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Sunsign>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Sunsign>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());



            // Act
            var mockContext = new Mock<HoroscopeAppDbContext>(options);
            mockContext.Setup(c => c.Sunsigns).Returns(mockSet.Object);

            var sunsignRepository = new SunsignRepository(mockContext.Object);
            var actualSunsign = await sunsignRepository.GetSunsign(expectedDate);


            //Assert
            Assert.IsNotNull(actualSunsign);
            Assert.AreEqual(expectedSunsign, actualSunsign);
        }

        //[TestCleanup]
        //public void Cleanup()
        //{
        //    _sunsignRepository = null;
        //}
    }
}
