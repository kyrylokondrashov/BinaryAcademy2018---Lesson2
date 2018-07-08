using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using еуые.Services;
using еуые.Models;
using System.Web.Mvc;

namespace еуые.Controllers
{
    public class PostController : Controller
    {
        private Service userServive;

        public PostController()
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
                    Post post = PostList.Where(p => p.Id == indx).Select(p=> p).FirstOrDefault();
                    ViewBag.UserName = (userServive.GetUsers()).Where(u => u.Id == post.UserId).Select(u => u.Name).FirstOrDefault();
                    return View(post);
                }
                catch
                {
                    ViewBag.Check = 3;
                    return View();
                }
            }
            return View();
        }
    }
}
