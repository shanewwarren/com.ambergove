﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace com.ambergove.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Appointments()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}