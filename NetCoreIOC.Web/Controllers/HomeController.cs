using Microsoft.AspNetCore.Mvc;
using NetCoreIOC.Service.Interfaces;
using NetCoreIOC.Web.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace NetCoreIOC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonDateService _singletonDateService;
        private readonly IScopedDateService _scopedDateService;
        private readonly ITransientDateService _transientDateService;

        public HomeController(ISingletonDateService singletonDateService, IScopedDateService scopedDateService, ITransientDateService transientDateService)
        {
            _singletonDateService = singletonDateService;
            _scopedDateService = scopedDateService;
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices] ITransientDateService transientDateService)
        {
            return View(new List<DateTimeViewModel>() {
                new DateTimeViewModel { DateTimeNow = _singletonDateService.DateTimeNow },
                new DateTimeViewModel { DateTimeNow = _scopedDateService.DateTimeNow },
                new DateTimeViewModel { DateTimeNow = _transientDateService.DateTimeNow },
                new DateTimeViewModel { DateTimeNow = transientDateService.DateTimeNow }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}