﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
    }
}