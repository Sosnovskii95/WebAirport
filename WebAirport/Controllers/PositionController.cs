using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;
using WebAirport.Models;

namespace WebAirport.Controllers
{
    public class PositionController : Controller
    {
        private AirportContext db = new AirportContext();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Position position)
        {
            db.Positions.Add(position);
            db.SaveChanges();

            return RedirectToAction("Position", "Home");
        }

        public ActionResult ListPosition()
        {
            ViewBag.Positions = db.Positions.ToList();
            return View();
        }
        
        
        public ActionResult Edit(int id)
        {
            ViewBag.Position = db.Positions.
                Where(c => c.PositionId == id).
                FirstOrDefault();

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Position position)
        {
            db.Entry(position).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ListPosition");
        }

    }
}