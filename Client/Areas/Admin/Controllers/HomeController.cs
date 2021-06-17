using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http.Json;
using Client.Models;
using Newtonsoft.Json;
using Client.ServiceAPI;
namespace Client.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/home")]
    public class HomeController : Controller
    {
        private ISeminarAPI seminarAPI;
        public HomeController(ISeminarAPI _seminarAPI)
        {
            seminarAPI = _seminarAPI;
        }
        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.listSeminar = seminarAPI.findResent();
            return View();
        }
    }
}
