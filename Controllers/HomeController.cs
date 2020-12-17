using DevOpsSettings.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DevOpsSettings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["myTargeted"] = _configuration["MyTargeted"];
            ViewData["myKeyValue"] = _configuration["MyKey"];
            ViewData["positionTitle"] = _configuration["Position:Title"];
            ViewData["positionName"] = _configuration["Position:Name"];

            var domain = $"{ HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            ViewData["domain"] = domain;

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
