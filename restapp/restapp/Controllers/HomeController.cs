using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to our restaurant ASP.NET MVC application!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
