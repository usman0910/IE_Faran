using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemeEmbeding.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashbord()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Stocks()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult Deliveries()
        {
            return View();
        }

    }
}