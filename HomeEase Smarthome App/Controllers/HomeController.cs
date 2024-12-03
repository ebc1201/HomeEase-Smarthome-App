using System.Diagnostics;
using HomeEase_Smarthome_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeEase_Smarthome_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult splash()
        {
            ViewData["Title"] = "Splash";
            return View();
        }


        public IActionResult Devices()
        {
            ViewData["Title"] = "Devices";
            return View();
        }


        public IActionResult Account()
        {
            ViewData["Title"] = "Account";
            return View();
        }

        public IActionResult Alarms()
        {
            ViewData["Title"] = "Alarms";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
