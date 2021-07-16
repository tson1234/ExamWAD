using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult form1(string txtSubject, DateTime txtStarttime, int txtExamDate, int txtDuration, string txtClassroom, string txtFaculty)
        {
            ViewBag.subject = txtSubject;
            ViewBag.starttime = txtStarttime;
            ViewBag.examDate = txtExamDate;
            ViewBag.duration = txtDuration;
            ViewBag.classroom = txtClassroom;
            ViewBag.faculty = txtFaculty;

            return View("Index");
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
    }
}