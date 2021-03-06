﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAirport.Data;
using WebAirport.Models.CodeFirst;
using X.PagedList;

namespace WebAirport.Controllers
{
    public class PositionController : Controller
    {
        private AirportContext db;

        public PositionController(AirportContext context)
        {
            db = context;
        }

        public IActionResult Index(int? page, string jobTitle)
        {
            int pageSize = 30;
            int pageNumber = (page ?? 1);
            List<Position> positionList = null;

            if (jobTitle != null && !jobTitle.Equals(""))
            {
                positionList = db.Positions.Where(p => p.JobTitle.Contains(jobTitle)).ToList();
                ViewBag.JobTitle = jobTitle;
            }
            else
            {
                positionList = db.Positions.ToList();
            }

            return View(positionList.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Position position)
        {
            if (ModelState.IsValid)
            {
                db.Positions.Add(position);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
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
        public IActionResult Edit(Position position)
        {
            if (ModelState.IsValid)
            {
                db.Positions.Update(position);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var position = db.Positions.Find(id);

                if (position != null)
                {
                    if (db.Staffs.Where(p => p.PositionId == id).Count() > 0)
                    {
                        var staffsList = db.Staffs.Where(p => p.PositionId == id).ToList();
                        ViewBag.positionsList = db.Positions.ToList();
                        ViewBag.currentPosition = position;

                        return View(staffsList);
                    }
                    else
                    {
                        db.Positions.Remove(position);
                        db.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int currentId, List<int> id, List<int> positionId)
        {
            if (id != null && positionId != null)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    if (positionId[i] != currentId)
                    {
                        var staff = db.Staffs.Find(id[i]);

                        staff.PositionId = positionId[i];
                        db.Staffs.Update(staff);
                    }

                }
                db.SaveChanges();
            }

            return RedirectToAction("Delete", new { currentId });
        }
    }
}