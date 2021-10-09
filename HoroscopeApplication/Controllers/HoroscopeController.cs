using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Controllers
{
    public class HoroscopeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
