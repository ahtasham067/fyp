using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FYP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            

            return View();
        }
        public ActionResult AddLoginDetail()
        {
            return View();
        }
        public ActionResult DomainandAlliedFields()
        {
            return View();
        }
        public ActionResult ExternalEvaluation()
        {
            return View();
        }
        public ActionResult InternalEvaluation()
        {
            return View();
        }
        public ActionResult MeetingForm()
        {
            return View();
        }
        public ActionResult ProposalEvaluationForm()
        {
            return View();
        }
        
            public ActionResult SDDEvaluationForm()
        {
            return View();
        }
        public ActionResult SRSEvaluationForm()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        
        public ActionResult SupervisorandCosupervisor()
        {
            return View();
        }
        public ActionResult SupervisorEvaluation()
        {
            return View();
        }
        public ActionResult TeacherIndex()
        {
            return View();
        }
        public ActionResult UpdateEvaluationMarks()
        {
            return View();
        }

    }
}