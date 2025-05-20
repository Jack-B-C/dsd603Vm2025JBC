using dsd603Vm2025JBC.Models;
using dsd603Vm2025JBC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dsd603Vm2025JBC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITextFileOperations _textFileOperations;
        private readonly IDataSeeder _dataSeeder;

        public HomeController(ILogger<HomeController> logger, ITextFileOperations textFileOperations, IDataSeeder dataSeeder)
        {
            _logger = logger;
            _textFileOperations = textFileOperations;
            _dataSeeder = dataSeeder;
        }
        
        
        public IActionResult Index()
        {
            ViewBag.Welcome = "Welcome to the VMS";

           ViewBag.VisitorNew = new Visitors()
            {
                FirstName = "Howard",
                LastName = "The Barbarian"
            };

            ViewData[index:"AnotherWelcome"] = "Please enter your name";
            _dataSeeder.SeedAsync();
            ViewData["Conditions"] = _textFileOperations.LoadConditionsForAcceptanceText();
            

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
