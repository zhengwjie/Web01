using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web01.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string GetStudentCount(string classId)
        {
            if (classId == "32")
            {
                return "45";
            }
            else
                return "0";
        }
    }
}