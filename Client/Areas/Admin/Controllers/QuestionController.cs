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

            return View();
        }
        [Route("delQuestion")]
        public IActionResult DelQuestion(int idQuestion)
        {
            
            var listQuestion = questionAPI.delQuestion(idQuestion);
            return new JsonResult(listQuestion);
        }
        [Route("detailQues")]
        public IActionResult DetailQuestion(int idQues)
        {
            var question = questionAPI.DetailQuestion(idQues);
            ViewBag.Question = question;
            ViewBag.listAnswer = question.Answers;
            return View();
        }
    }
}
