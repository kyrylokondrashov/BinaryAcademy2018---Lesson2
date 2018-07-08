using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using еуые.Services;
using еуые.Models;

namespace еуые.Controllers
{
    public class UserController : Controller
    {
        private Service userServive;

        public UserController()
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
                    User user = (userServive.GetUsers()).Where(u => u.Id == indx).Select(u => u).FirstOrDefault();
                    ViewBag.AdressName = user.adress.Country;
                    ViewBag.AdressId = user.adress.Id;
                    return View(user);
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