using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;
using WebAirport.Models;
using System.Data.Entity;

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

        [HttpPost]
        public void Create(Flight flight, JobAirplane jobAirplane)
        {
            db.JobAirplanes.Add(jobAirplane);
            db.SaveChanges();

            flight.JobAirplaneId = jobAirplane.Id;
            db.Flights.Add(flight);
            db.SaveChanges();
        }

        public ActionResult ListFlight()
        {
            var flights = db.Flights.ToList();

            return View(flights);
        }

        [HttpPost]
        public ActionResult ListTypeSelected(int id)
        {
            var type = db.TypeAirplanes.ToList();

            ViewBag.IdSelected = id;

            return PartialView(type);
        }

        [HttpPost]
        public ActionResult ListAirplaneSelected(int idType, int idAir)
        {
            var airplane = db.Airplanes.Where(c => c.TypeAirplaneId == idType).ToList();

            ViewBag.idSelected = idAir;

            return PartialView(airplane);
        }

        [HttpPost]
        public ActionResult ListStaffSelected(int idStaff)
        {
            var staffs = db.Staffs.ToList();
            
            ViewBag.idStaff = idStaff;

            return PartialView(staffs);
        }

        public ActionResult Edit(int id)
        {
            var flight = db.Flights.Include(p => p.JobAirplane).
                                    Include(j => j.JobAirplane.Airplane).
                                    Include(s => s.JobAirplane.Staff).
                                    Where(i => i.Id == id).
                                    ToList();

            return View(flight);
        }

        [HttpPost]
        public ActionResult Edit(Flight flight, JobAirplane jobAirplane)
        {
            db.Entry(flight).State = EntityState.Modified;
            db.Entry(jobAirplane).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ListFlight");
        }
    }
}