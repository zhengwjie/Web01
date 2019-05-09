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
        public List<Comment> commentList = new List<Comment>();
        public CommentsController()
        {
            //commentList.
            commentList.Add(new Comment { ID = 0, Author = "王小强", Text = "太精彩了！！！" });
            commentList.Add(new Comment { ID = 1, Author = "王大才", Text = "一点也不好看" });
            commentList.Add(new Comment { ID = 2, Author = "王大才", Text = "一点也不好看" });
        }
        public ActionResult GetComments(Comment comment)
        {
            commentList.Add(comment);
            ViewData.Model= commentList;
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
        public Comment DeleteComment(int id)
        {
            Comment comment = new Comment();
            if (!commentReposity.TryGetComment(id, out comment))
                throw new HttpResponseException(HttpStatusCode.NotFound);
            commentReposity.DeleteComment(id);
            return comment;
        }
        public HttpResponseMessage PostComment(Comment comment)
        {
            comment = commentReposity.AddComment(comment);
            var response = new HttpResponseMessage( HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.Url,"api/comments/");
            return response;
        }

    }
}