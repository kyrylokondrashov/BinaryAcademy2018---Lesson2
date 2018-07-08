using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using еуые.Services;
using еуые.Models;

namespace еуые.Controllers
{
    public class CommentController : Controller
    {
        private Service userServive;
  
        public CommentController()
        {
            userServive = new Service();
        }

        public ActionResult Index(string searchId)
        {
            ViewBag.Check = 0;
            if (searchId != null)
            {
                ViewBag.Check = 1;
                try
                {
                    int indx = Convert.ToInt32(searchId);
                    var PostList = (userServive.GetUsers()).SelectMany(p => p.posts);
                    var CommentList = PostList.SelectMany(a => a.comments);
                    Comment comment = CommentList.Where(c => c.Id == indx).Select(c => c).FirstOrDefault();
                    ViewBag.PostId = Convert.ToString(comment.PostId);
                    ViewBag.UserName = (userServive.GetUsers()).Where(u => u.Id == comment.UserId).Select(u => u.Name).FirstOrDefault();
                    return View(comment);
                }
                catch
                {
                    ViewBag.Check = 2;
                    return View();
                }
            }
            return View();
        }
    }
}