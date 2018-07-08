using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using еуые.Services;
using еуые.BuisnessLogic;
using еуые.Models;
using System.Web.Mvc;

namespace еуые.Controllers
{
    public class Task6Controller : Controller
    {
        // GET: Task6
        private Service userServive;

        public Task6Controller()
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
                    StructureForTask6 result = BuisnessLogic.Tasks.Task6(indx);
                    return View(result);
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