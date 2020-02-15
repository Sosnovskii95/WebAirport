using PagedList;
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

        public ActionResult Index(int? page)
        {
            var listPosition = db.Positions.ToList();
            int pageSize = 30;
            int pageNumber = (page ?? 1);
            return View(listPosition.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Position position)
        {
            db.Positions.Add(position);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var position = db.Positions.Find(id);
                return View(position);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Edit(Position position)
        {
            if (ModelState.IsValid)
            {
                db.Entry(position).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                int countPosStaff = db.Staffs.Where(p => p.PositionId == id).Count();
                var position = db.Positions.Find(id);

                if (countPosStaff == 0)
                {
                    db.Positions.Remove(position);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    var staffsList = db.Staffs.Where(p => p.PositionId == id).ToList();
                    ViewBag.positionsList = new SelectList(db.Positions, "Id", "JobTitle");
                    ViewBag.currentPosition = position;

                    return View(staffsList);
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Delete(int currentId, List<int> id, List<int> positionId)
        {
            for (int i = 0; i < id.Count; i++)
            {
                var staff = db.Staffs.Find(id[i]);

                staff.PositionId = positionId[i];
                db.Entry(staff).State = EntityState.Modified;
                
            }
            db.SaveChanges();

            return RedirectToAction("Delete", new { id = currentId });
        }
    }
}