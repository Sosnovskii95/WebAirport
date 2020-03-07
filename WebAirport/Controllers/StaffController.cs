using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAirport.Models.CodeFirst;
using WebAirport.Data;
using X.PagedList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebAirport.Controllers
{
    public class StaffController : Controller
    {
        private AirportContext db;

        public StaffController(AirportContext context)
        {
            db = context;
        }

        public IActionResult Index(int? page, string fioStaff, string address)
        {
            List<Staff> staffList = null; ;
            int pageSize = 30;
            int pageNumber = (page ?? 1);

            if (fioStaff != null && !fioStaff.Equals("") && address != null && !address.Equals(""))
            {
                staffList = db.Staffs.Include(p => p.Position).
                                      Where(f => f.FIOStaff.Contains(fioStaff)).
                                      Where(a => a.Address.Contains(address)).
                                      ToList();
                ViewBag.FIOStaff = fioStaff;
                ViewBag.Address = address;
            }
            else if (fioStaff != null && !fioStaff.Equals(""))
            {
                staffList = db.Staffs.Include(p => p.Position).
                                      Where(f => f.FIOStaff.Contains(fioStaff)).
                                      ToList();
                ViewBag.FIOStaff = fioStaff;
            }
            else if (address != null && !address.Equals(""))
            {
                staffList = db.Staffs.Include(p => p.Position).
                                      Where(a => a.Address.Contains(address)).
                                      ToList();
                ViewBag.Address = address;
            }
            else
            {
                staffList = db.Staffs.Include(p => p.Position).ToList();
            }

            return View(staffList.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Create()
        {
            ViewBag.Positions = new SelectList(db.Positions, "Id", "JobTitle");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
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
        public IActionResult Edit(Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var staff = db.Staffs.Find(id);

                if (staff != null)
                {
                    if (db.JobAirplanes.Where(s => s.StaffId == id).Count() > 0)
                    {
                        var flightsList = db.Flights.Where(j => j.JobAirplane == db.JobAirplanes.
                                                     Where(s => s.StaffId == id).FirstOrDefault()).ToList();
                        ViewBag.staffsList = db.Staffs.ToList();
                        ViewBag.currentStaff = staff;

                        return View(flightsList);
                    }
                    else
                    {
                        db.Staffs.Remove(staff);
                        db.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int currentId, List<int> id, List<int> staffId)
        {
            if (id != null && staffId != null)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    if (staffId[i] != currentId)
                    {
                        var jobAirplane = db.JobAirplanes.Where(s => s.StaffId == currentId).FirstOrDefault();

                        jobAirplane.StaffId = staffId[i];
                        db.Entry(jobAirplane).State = EntityState.Modified;
                    }
                }
                db.SaveChanges();
            }

            return RedirectToAction("Delete", new { currentId });
        }
    }
}