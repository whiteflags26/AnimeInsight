using AnimeInsight.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AnimeInsight.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OracleHelper _oracleHelper;

        public HomeController(ILogger<HomeController> logger, OracleHelper oracleHelper)
        {
            _logger = logger;
            _oracleHelper = oracleHelper;
        }

        public IActionResult Index()
        {
            string result = _oracleHelper.ExecuteHelloWorldFunction();

            ViewBag.Result = result;

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
