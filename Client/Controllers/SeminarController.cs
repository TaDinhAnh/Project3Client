using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    [Route("serminar")]
    public class SeminarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("details")]
        public IActionResult Details()
        {
            return View();
        }
    }
}
