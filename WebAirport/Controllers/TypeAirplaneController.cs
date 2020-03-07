using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAirport.Data;
using WebAirport.Models.CodeFirst;
using X.PagedList;

namespace WebAirport.Controllers
{
    public class TypeAirplaneController : Controller
    {
        private AirportContext db;

        public TypeAirplaneController(AirportContext context)
        {
            db = context;
        }

        // GET: TypeAirplane
        public IActionResult Index(int? page, string typeSearch)
        {
            int pageSize = 30;
            int pageNumber = (page ?? 1);
            List<TypeAirplane> typeAirplaneList = null;

            if (typeSearch != null && !typeSearch.Equals(""))
            {
                typeAirplaneList = db.TypeAirplanes.Where(n => n.NameType.Contains(typeSearch)).ToList();
                ViewBag.TypeSearch = typeSearch;
            }
            else
            {
                typeAirplaneList = db.TypeAirplanes.ToList();
            }

            return View(typeAirplaneList.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TypeAirplane typeAirplane)
        {
            if (ModelState.IsValid)
            {
                db.TypeAirplanes.Add(typeAirplane);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var typeAirplane = db.TypeAirplanes.Find(id);
                return View(typeAirplane);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(TypeAirplane typeAirplane)
        {
            if (ModelState.IsValid)
            {
                db.TypeAirplanes.Update(typeAirplane);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var typeAirplane = db.TypeAirplanes.Find(id);
                if (typeAirplane != null)
                {
                    if (db.Airplanes.Where(i => i.TypeAirplaneId == id).Count() > 0)
                    {
                        var airplaneList = db.Airplanes.Where(i => i.TypeAirplaneId == id).ToList();
                        ViewBag.typeAirplanesList = db.TypeAirplanes.ToList();
                        ViewBag.currentTypeAirplane = typeAirplane;

                        return View(airplaneList);
                    }
                    else
                    {
                        db.TypeAirplanes.Remove(typeAirplane);
                        db.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int currentId, List<int> id, List<int> typeAirplaneId)
        {
            if (id != null && typeAirplaneId != null)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    if (typeAirplaneId[i] != currentId)
                    {
                        var airplane = db.Airplanes.Find(id[i]);

                        airplane.TypeAirplaneId = typeAirplaneId[i];
                        db.Airplanes.Update(airplane);
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("Delete", new { currentId });
        }
    }
}