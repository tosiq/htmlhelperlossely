using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult about()
        {
            ViewBag.a = "tosiq ahmed";
            ViewData["b"] = "laiq ahmed";
            TempData["c"] = 12 + 78;
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
    }
}