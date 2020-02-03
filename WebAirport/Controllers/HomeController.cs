using System;
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
            DbInit.Initialize(airportContext);
            return View();
        }

        public ActionResult Position()
        {
            return View();
        }

        public ActionResult Staff()
        {
            return View();
        }

        public ActionResult TypeAirplane()
        {
            return View();
        }

        public ActionResult Airplane()
        {
            return View();
        }

        public ActionResult Flight()
        {
            return View();
        }
    }
}