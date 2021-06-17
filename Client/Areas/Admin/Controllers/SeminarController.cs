using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Client.Models;
using System.Net.Http.Json;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Client.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/seminar")]
    public class SeminarController : Controller
    {
        [Route("index")]
        public   IActionResult Index()
        {
            return View();
        }
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
      
    }
}
