using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Client.ServiceAPI;
namespace Client.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/account")]
    public class AccountController : Controller
    {
        private IAccountAPI accountAPI;
        public AccountController(IAccountAPI _accountAPI)
        {
            accountAPI = _accountAPI;
        }
        public IActionResult Index()
        {
            ViewBag.listAccount = accountAPI.findAll();
            return View();
        }
    }
}
