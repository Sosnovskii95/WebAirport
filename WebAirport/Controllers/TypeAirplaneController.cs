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
    public class TypeAirplaneController : Controller
    {
        private AirportContext db = new AirportContext();

        // GET: TypeAirplane
        public ActionResult Index()
        {
            return View();
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

            return RedirectToAction("ListTypeAirplane");
        }

        public ActionResult ListTypeAirplane()
        {
            ViewBag.TypeAirplanes = db.TypeAirplanes.ToList();

            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.TypeAirplane = db.TypeAirplanes.Find(id);

            return View();
        }

        [HttpPost]
        public ActionResult Edit(TypeAirplane typeAirplane)
        {
            db.Entry(typeAirplane).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ListTypeAirplane");
        }
    }
}