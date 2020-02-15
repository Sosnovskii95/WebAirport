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
    public class TypeAirplaneController : Controller
    {
        private AirportContext db = new AirportContext();

        // GET: TypeAirplane
        public ActionResult Index(int? page)
        {
            int pageSize = 30;
            int pageNumber = (page ?? 1);
            var listTypeAirplane = db.TypeAirplanes.ToList();
            return View(listTypeAirplane.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TypeAirplane typeAirplane)
        {
            db.TypeAirplanes.Add(typeAirplane);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                ViewBag.TypeAirplane = db.TypeAirplanes.Find(id);
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Edit(TypeAirplane typeAirplane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeAirplane).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}