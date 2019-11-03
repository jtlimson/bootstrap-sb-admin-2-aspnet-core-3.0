using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bootstrap_sb_admin_2_aspnet_core.Models;

namespace bootstrap_sb_admin_2_aspnet_core.Controllers
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
            return View();
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

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Cards()
        {
            return View();
        }

        public IActionResult UtilitiesColor() {
            return View();
        }

        public IActionResult UtilitiesBorder()
        {
            return View();
        }

        public IActionResult UtilitiesAnimation()
        {
            return View();
        }

        public IActionResult UtilitiesOther()
        {
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }


        public IActionResult Tables()
        {
            return View();
        }



    }
}
