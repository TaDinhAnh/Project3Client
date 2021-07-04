using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Client.ServiceAPI;

namespace Client.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/survey")]
    public class SurveyController : Controller
    {
        private ISurveyAPI surveyAPI;
        public SurveyController(ISurveyAPI _surveyAPI)
        {
            surveyAPI = _surveyAPI;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.listSurvey = surveyAPI.FindAll();
            return View();
        }
    }
}
