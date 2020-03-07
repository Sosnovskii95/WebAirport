using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAirport.Data;
using WebAirport.Models.CodeFirst;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace WebAirport.Controllers
{
    public class AirplaneController : Controller
    {
        private AirportContext db;
        
        public AirplaneController(AirportContext context)
        {
            db = context;
        }

        public IActionResult Index(int? page, int? typeAirplaneId)
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

        public IActionResult Create()
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
        public IActionResult Create(Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                db.Airplanes.Add(airplane);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
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
        public IActionResult Edit(Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                db.Airplanes.Update(airplane);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var airplane = db.Airplanes.Find(id);

                if (airplane != null)
                {
                    if (db.Flights.Where(j => j.JobAirplane.AirplaneId == id).Count() > 0)
                    {
                        var flightList = db.Flights.Where(j => j.JobAirplane.AirplaneId == id).ToList();
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
        public IActionResult Delete(int currentId, List<int> id, List<int> airplaneId)
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