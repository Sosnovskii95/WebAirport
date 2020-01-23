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
           /* Airplane airplane = new Airplane { Model = "1" };
            airportContext.Airplanes.Add(airplane);
            airportContext.SaveChanges();*/


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}