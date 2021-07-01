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
        private IScoreAPI scoreAPI;
        public HomeController(ISeminarAPI _seminarAPI, IScoreAPI _scoreAPI)
        {
            seminarAPI = _seminarAPI;
            scoreAPI = _scoreAPI;
        }
        [Route("Index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.listSeminarDTO = seminarAPI.findResent(4);
            ViewBag.listScore = scoreAPI.Top(3);
           
            return View();
        }
    }
}
