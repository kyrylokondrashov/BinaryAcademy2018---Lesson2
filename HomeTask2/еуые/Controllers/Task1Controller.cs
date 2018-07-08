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
    public class Task1Controller : Controller
    {
        // GET: Task1
  
        private Service userServive;

        public Task1Controller()
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
                    List<User> users = userServive.GetUsers();
                    ViewBag.Index = indx;
                    User specificUser = users.Where(u => u.Id == indx).FirstOrDefault();
                    ViewBag.UserName = specificUser.Name;
                    ViewBag.UserId = specificUser.Id;
                    List<Post> result = BuisnessLogic.Tasks.Task1(specificUser);
                    return View(result);
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