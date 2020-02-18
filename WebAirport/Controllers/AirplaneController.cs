using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;
using WebAirport.Models;
using System.Data.Entity;
using PagedList;

namespace WebAirport.Controllers
{
    public class AirplaneController : Controller
    {
        private AirportContext db = new AirportContext();
        // GET: Airplane
        public ActionResult Index(int? page, int? typeAirplaneId)
        {
            int pageSize = 30;
            int pageNumber = (page ?? 1);

            IEnumerable<Airplane> airplaneList = null;
            if (typeAirplaneId != null && typeAirplaneId != 0)
            {
                airplaneList = db.Airplanes.
                    Include(t => t.TypeAirplane).
                    Where(t => t.TypeAirplaneId == typeAirplaneId).ToList();
            }
            else
            {
                airplaneList = db.Airplanes.
                    Include(t => t.TypeAirplane).ToList();
            }

            var typeAirplane = db.TypeAirplanes.ToList();
            typeAirplane.Insert(0, new TypeAirplane { Id = 0, NameType = "Все" });
            ViewBag.TypeAirplane = new SelectList(typeAirplane, "Id", "NameType");

            return View(airplaneList.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            //Проверить на чистой бд
            if (db.TypeAirplanes.Count() != 0)
            {
                ViewBag.TypeAirplanes = new SelectList(db.TypeAirplanes, "Id", "NameType");
            }
            else
            {
                ViewBag.TypeAirplanes = null;
            }

            return View();
        }

        [HttpPost]
        public ActionResult Create(Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                db.Airplanes.Add(airplane);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var airplane = db.Airplanes.Find(id);

                if (db.TypeAirplanes.Count() != 0)
                {
                    ViewBag.TypeAirplanes = new SelectList(db.TypeAirplanes, "Id", "NameType");
                }
                else
                {
                    ViewBag.TypeAirplanes = null;
                }

                return View(airplane);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Edit(Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airplane).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var airplane = db.Airplanes.Find(id);

                if (airplane != null)
                {
                    if (db.JobAirplanes.Where(a => a.AirplaneId == id).Count() > 0)
                    {
                        var flightList = db.Flights.Where(j => j.JobAirplane == db.JobAirplanes.
                                                    Where(a => a.AirplaneId == id).FirstOrDefault()).ToList();
                        ViewBag.airplaneList = db.Airplanes.ToList();
                        ViewBag.currentAirplane = airplane;

                        return View(flightList);
                    }
                    else
                    {
                        db.Airplanes.Remove(airplane);
                        db.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int currentId, List<int> id, List<int> airplaneId)
        {
            if (id != null && airplaneId != null)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    if (airplaneId[i] != currentId)
                    {
                        var jobAirplane = db.JobAirplanes.Where(a => a.AirplaneId == currentId).FirstOrDefault();

                        jobAirplane.AirplaneId = airplaneId[i];
                        db.Entry(jobAirplane).State = EntityState.Modified;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("Delete", new { currentId });
        }
    }
}