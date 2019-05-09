using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web01.Controllers
{
    public class MVCController : Controller
    {
        // GET: MVC
        public ActionResult Index()
        {
            string[] data = new string[4];
            data[0] = "张三";
            data[1] = "男";
            data[2] = "教务处";
            data[3] = "123456789";
            ViewData["d"] = data;
            return View();

            return View();
        }
        
    }
}