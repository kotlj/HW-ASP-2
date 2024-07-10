using HW_ASP_2.Models;
using HW_ASP_2.Services.PasswordGenerator;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW_ASP_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPasswordGenerator _passwordGenerator;


        public HomeController(ILogger<HomeController> logger, IPasswordGenerator passwordGenerator)
        {
            _logger = logger;
            _passwordGenerator = passwordGenerator;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult HW_1()
        {
            ViewData["Password"] = _passwordGenerator.Generate();
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
