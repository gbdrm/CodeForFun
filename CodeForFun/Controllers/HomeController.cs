using CodeForFun.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeForFun.Controllers
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

        public IActionResult Profile()
        {
            ViewBag.Bio = "I am Viktor. Millenial from 🇺🇦 Ukraine 💛💙, currently based in Silicon Valley 👩‍💻🌉👨‍💻 and work as Engineering manager. I'm driven by a passion for continuous learning and growth🌱, challenging myself and others 🎖️ and making the future come faster 🤖.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
