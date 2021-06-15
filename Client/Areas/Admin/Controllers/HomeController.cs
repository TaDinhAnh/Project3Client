using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/home")]
    public class HomeController : Controller
    {
        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
