using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.ServiceAPI;
using System.Net.Http.Json;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Client.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/seminar")]
    public class SeminarController : Controller
    {
        private ISeminarAPI seminarAPI;
        public SeminarController(ISeminarAPI _seminarAPI)
        {
            seminarAPI = _seminarAPI;
        }
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.listSeminar = seminarAPI.findAll();
            return View();
        }
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

    }
}
