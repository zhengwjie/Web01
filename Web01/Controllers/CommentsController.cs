using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web01.Models;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace Web01.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Comments
        public DictionaryCommentRepository commentReposity = new DictionaryCommentRepository();
        public static List<Comment> commentList = new List<Comment>();


        public CommentsController()
        {
            //commentList
            if(commentList.Count==0)
            {
                commentList.Add(new Comment { ID = 0, Author = "王小强", Text = "太精彩了！！！" });
                commentList.Add(new Comment { ID = 1, Author = "王大才", Text = "一点也不好看" });
                commentList.Add(new Comment { ID = 2, Author = "张有才", Text = "凑活" });
            }
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult GetComments(string author,string text)
        {
            commentList.Add(new Comment() { ID = commentList.Count, Author=author,Text=text});
            ViewData.Model= commentList;
            return View();
        }
        public ActionResult GetComments()
        {
            ViewData.Model = commentList;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetComment(int id)
        {
            List<Comment> commList = new List<Comment>();
            if(commentList.Count>id)
            {
                commList.Add(commentList[id]);
                ViewData.Model = commList;
                return View();
            }
            else
            {
                commList.Add(new Comment {ID=10000, Author = "抱歉", Text = "没有这个ID" });
                ViewData.Model = commList;
                return View();
            }
        }

    }
}