using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using еуые.Services;
using еуые.Models;
using System.Web.Mvc;

namespace еуые.Controllers
{
    public class AdressController : Controller
    {
        private Service userServive;

        public AdressController()
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
                    Adress adress = (userServive.GetUsers()).Where(a => a.adress.Id == indx).Select(a => a.adress).FirstOrDefault();
                    ViewBag.UserName = (userServive.GetUsers()).Where(a => a.adress.Id == indx).Select(a => a.Name).FirstOrDefault();
                    return View(adress);
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