using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Models;
using WebAirport.Data;
using System.Data.Entity;
using PagedList;

namespace WebAirport.Controllers
{
    public class StaffController : Controller
    {
        private AirportContext db = new AirportContext();

        public ActionResult Index(int? page)
        {
            var listStaff = db.Staffs.
                Include(s => s.Position).ToList();
            int pageSize = 30;
            int pageNumber = (page ?? 1);
            return View(listStaff.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            ViewBag.Positions = new SelectList(db.Positions, "Id", "JobTitle");

            return View();
        }

        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            db.Staffs.Add(staff);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                var staff = db.Staffs.Find(id);

                ViewBag.Positions = new SelectList(db.Positions, "Id", "JobTitle");

                return View(staff);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Edit(Staff staff)
        {
            db.Entry(staff).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}