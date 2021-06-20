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
    [Route("admin/question")]
    public class QuestionController : Controller
    {
        private IQuestionAPI questionAPI;
        private IAnswerAPI answerAPI;
        public QuestionController(IQuestionAPI _questionAPI, IAnswerAPI _answerAPI)
        {
            questionAPI = _questionAPI;
            answerAPI = _answerAPI;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.listQuestion = questionAPI.findAll();
            ViewBag.listAnswer = answerAPI.findAll();
            return View();
        }
    }
}
