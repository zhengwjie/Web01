using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Index1()
        {
            string[] parameter = new string[4];
            parameter[0] = RouteData.Values["controller"].ToString();
            parameter[1] = RouteData.Values["action"].ToString();
            parameter[2] = RouteData.Values["id"].ToString();
            parameter[3] = RouteData.Values["plus"].ToString();
            ViewData["msg"] = parameter;
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult JsonDemo()
        {
            string s = "JsonDemo的运行结果：" + DateTime.Now.ToString();
            return Json(s);
        }
        public ActionResult JavaScriptDemo()
        {
            string js = "JavaStriptDemo运行结果：" + DateTime.Now.ToString();
            return JavaScript(js);
        }
        public ActionResult First()
        {
            ViewData["msg"] = "这是First视图";
            return View();
        }
        public ActionResult Second()
        {
            ViewData["msg"] = "这是Second视图";
            return View();

        }
        public string testString()
        {
            return "这是一个字符串！！<h1>test</h1>";
        }
        public ActionResult IndexA()
        {
            return Redirect("https://www.baidu.com");
        }
        public ActionResult ContentTest()
        {
            return Content("这是一个字符串！！<h1>test</h1>", "text/Plain");
        }
        public ActionResult view01()
        {
            return View();
        }
    }
}
