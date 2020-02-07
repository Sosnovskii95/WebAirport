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
            ViewBag.Position = db.Positions.Find(id);

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Position position)
        {
            db.Entry(position).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ListPosition");
        }

        public ActionResult Delete(int id)
        {
            var Staffs = db.Staffs.
                        Where(p => p.PositionId == id).
                        ToList();

            if(Staffs.Count == 0)
            {
                var position = db.Positions.Find(id);

                if(position != null)
                {
                    db.Positions.Remove(position);
                    db.SaveChanges();
                }               
                return RedirectToAction("ListPosition");
            }

            ViewBag.CurrentPosition = db.Positions.Find(id);
            ViewBag.ListPosition = db.Positions.ToList();

            return View(Staffs);
        }

        [HttpPost]
        public void Delete(int [] arrStaff, int newIdPos)
        {
            if (arrStaff.Length > 0)
            {
                for (int i = 0; i < arrStaff.Length; i++)
                {
                    var staff = db.Staffs.Find(arrStaff[i]);
                    staff.PositionId = newIdPos;

                    db.Entry(staff).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
        }
    }
}