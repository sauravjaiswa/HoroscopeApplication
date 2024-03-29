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
        public async Task<IActionResult> Index(DateOfBirthViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    DateOfBirthViewModel dateOfBirthViewModel = new DateOfBirthViewModel
                    {
                        Dob = DateTime.UtcNow.Date,
                        SunsignBasicInfos = SunsignBasicInfoRepository.GetAllBasicInfo()
                    };
                    return View("~/Views/Home/Index.cshtml", dateOfBirthViewModel);
                }

                var date = model.Dob.ToShortDateString();
                var dateKey = date.Substring(0, date.LastIndexOf("-"));
                var sunsign = await _sunsignRepository.GetSunsign(dateKey);

                var horoscope = await _horoscopeRepository.GetHoroscope(sunsign);
                HoroscopeViewModel horoscopeViewModel = new HoroscopeViewModel
                {
                    Sunsign = sunsign,
                    Horoscope = horoscope
                };

                return View(horoscopeViewModel);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sunsign)
        {
            try
            {
                var horoscope = await _horoscopeRepository.GetHoroscope(sunsign);
                HoroscopeViewModel horoscopeViewModel = new HoroscopeViewModel
                {
                    Sunsign = sunsign,
                    Horoscope = horoscope
                };

                return View("Index", horoscopeViewModel);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
