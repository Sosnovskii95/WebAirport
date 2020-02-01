using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;

namespace WebAirport.Controllers
{
    public class FlightController : Controller
    {
        private AirportContext db = new AirportContext();

        // GET: Flight
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.TypeAirplane = db.TypeAirplanes.ToList();
            ViewBag.Staff = db.Staffs.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult ListAirplaneByType(int id)
        {
            var airplanes = db.Airplanes.Where(c => c.TypeAirplaneId == id).ToList();

            if (airplanes.Count <= 0)
            {
                return HttpNotFound();
            }

            return PartialView(airplanes);
        }
    }
}