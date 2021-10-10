﻿using HoroscopeApplication.Repository;
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
        private readonly ISunsignRepository _sunsignRepository;
        private readonly IHoroscopeRepository _horoscopeRepository;

        public HoroscopeController(ISunsignRepository sunsignRepository, IHoroscopeRepository horoscopeRepository)
        {
            _sunsignRepository = sunsignRepository;
            _horoscopeRepository = horoscopeRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Find(DateOfBirthViewModel model)
        {
            var date = model.Dob.ToShortDateString();
            var dateKey = date.Substring(0,date.LastIndexOf("-"));
            var sunsign = await _sunsignRepository.GetSunsign(dateKey);

            var horoscope = await _horoscopeRepository.GetHoroscope(sunsign);

            return RedirectToAction("Index", "Home");
        }
    }
}
