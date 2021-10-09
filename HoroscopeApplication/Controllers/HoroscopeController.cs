using HoroscopeApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Controllers
{
    public class HoroscopeController : Controller
    {
        [HttpPost]
        public IActionResult Find(DateOfBirthViewModel model)
        {
            var date = model.Dob;

            return RedirectToAction("Index", "Home");
        }
    }
}
