using InsuranceApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InsuranceApp.Controllers
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

        public IActionResult Pojisteni()
        {
            return View();
        }

        public IActionResult Prihlaseni()
        {
            return View();
        }
        public IActionResult Registrace()
        {
            return View();
        }

        public IActionResult Detail_Pojistence()
        {
            return View();
        }

        public IActionResult Novy_Pojistenec()
        {
            return View();
        }

        public IActionResult Upraveni_Pojistence()
        {
            return View();
        }

        public IActionResult Upraveni_Pojisteni()
        {
            return View();
        }

        public IActionResult Pridani_Pojisteni()
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