using System;
using System.Collections.Generic;
using System.Linq;
using еуые.Services;
using еуые.BuisnessLogic;
using еуые.Models;
using System.Web;
using System.Web.Mvc;

namespace еуые.Controllers
{
    public class AllUsersController : Controller
    {
        private Service userServive;

        public AllUsersController()
        {
            userServive = new Service();

        }
        // GET: AllUsers
        public ActionResult Index()
        {
            List<User> someUser = userServive.GetUsers();
            return View(someUser);
        }
    }
}