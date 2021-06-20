using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Client.ServiceAPI;

namespace Client.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IAccountAPI accountAPI;
        public HomeController(ILogger<HomeController> logger, IAccountAPI _accountAPI)
        {
            _logger = logger;
            accountAPI = _accountAPI;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {

            return View();
        }
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("login")]
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var acc = accountAPI.login(new Account { UserName = username, Password = password });
            if (acc == null) return View();

            return acc.Role switch
            {
                "sv" => Redirect("/home/index"),
                "gv" => Redirect("/admin/home/index"),
                _ => RedirectToAction("/home/Login")
            };
        }
        [Route("register")]
        public IActionResult Register()
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
