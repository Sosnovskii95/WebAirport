﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;
using WebAirport.Models;

namespace WebAirport.Controllers
{
    public class HomeController : Controller
    {
        private AirportContext airportContext = new AirportContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Position()
        {
            return View();
        }
    }
}