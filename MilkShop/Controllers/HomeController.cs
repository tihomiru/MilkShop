using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MilkShop.Models;

namespace MilkShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult KiseloMlqko()
        {
            return View();
        }
        public IActionResult PM()
        {
            return View();
        }
        public IActionResult Kashkava()
        {
            return View();
        }
        public IActionResult Sirene()
        {
            return View();
        }
        public IActionResult Special()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult ForUs()
        {
            return View();
        }
        public IActionResult Products()
		{
			return View();
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
    }
}
