using HoroscopeApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Controllers
{
    public class HistoryController : Controller
    {
        private readonly IHistoryRepository _historyRepository;

        public HistoryController(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public IActionResult Index()
        {
            var histories = _historyRepository.GetHistories("A");

            return View(histories);
        }

        public IActionResult ViewHistory(int id)
        {
            var history = _historyRepository.GetHistory("A", id);
            var horoscopeViewModel = history.SearchedHoroscope;

            //return View("~/Views/Horoscope/Index.cshtml", horoscopeViewModel);
            return Json(horoscopeViewModel);
        }
    }
}
