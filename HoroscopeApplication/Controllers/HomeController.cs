using HoroscopeApplication.Models;
using HoroscopeApplication.Repository;
using HoroscopeApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateOfBirthViewModel dateOfBirthViewModel = new DateOfBirthViewModel
            {
                Dob = DateTime.UtcNow.Date,
                SunsignBasicInfos = SunsignBasicInfoRepository.GetAllBasicInfo()
            };
            return View(dateOfBirthViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? code)
        {
            ErrorViewModel errorViewModel = new ErrorViewModel();
            if (code == 404)
            {
                errorViewModel.ErrorCode = "404";
                errorViewModel.ErrorMessage = "The requested page not found.";
            }
            else if(code == 500)
            {
                errorViewModel.ErrorCode = "500";
                errorViewModel.ErrorMessage = "Internal Server Error";
            }

            return View(errorViewModel);
        }
    }
}
