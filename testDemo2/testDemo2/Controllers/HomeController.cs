﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testDemo2.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index2()
        {
            return "Ello ma world";
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}