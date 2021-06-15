using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/account")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
