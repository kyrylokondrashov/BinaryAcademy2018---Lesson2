using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using еуые.Models;
using еуые.Services;
using System.Web.Mvc;

namespace еуые.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo
        private Service userServive;

        public TodoController()
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
                    var TodoList = (userServive.GetUsers()).SelectMany(a => a.todos);
                    Todo todo = TodoList.Where(t => t.Id == indx).Select(t => t).FirstOrDefault();
                    ViewBag.UserName = (userServive.GetUsers()).Where(u => u.Id == todo.UserId).Select(u => u.Name).FirstOrDefault();
                    if (todo.ISComplete)
                    {
                        ViewBag.Color ="#90ee90";
                        ViewBag.Status = "Completed";
                    }
                    else
                    {
                        ViewBag.Color = "#E77471";
                        ViewBag.Status = "Uncomplet";
                    }
                    return View(todo);
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