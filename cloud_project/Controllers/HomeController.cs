﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cloud_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Ahmed Mohammed Ahmed Qerem";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
