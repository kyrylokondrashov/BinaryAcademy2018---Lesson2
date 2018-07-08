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
    public class Task4Controller : Controller
    {
        // GET: Task4
        public ActionResult Index()
        {
            List<User> someUser = BuisnessLogic.Tasks.Task4();
            return View(someUser);
        }
    }
}