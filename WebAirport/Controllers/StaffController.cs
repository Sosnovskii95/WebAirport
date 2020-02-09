﻿using System;
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
            ViewBag.Positions = db.Positions.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            db.Staffs.Add(staff);
            db.SaveChanges();

            return RedirectToAction("ListStaff");
        }

        public ActionResult ListStaff()
        {
            ViewBag.Staffs = db.Staffs.
                Include(s => s.Position).ToList();

            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Staff = db.Staffs.
                Where(c => c.Id == id).
                Include(p => p.Position).ToList();

            ViewBag.Positions = db.Positions.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Staff staff)
        {
            db.Entry(staff).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ListStaff");
        }
    }
}