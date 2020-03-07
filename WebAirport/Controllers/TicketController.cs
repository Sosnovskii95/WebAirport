using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAirport.Data;
using WebAirport.Models.CodeFirst;
using X.PagedList;

namespace WebAirport.Controllers
{
    public class TicketController : Controller
    {
        private AirportContext db;

        public TicketController(AirportContext context)
        {
            db = context;
        }

        public IActionResult Index(int? page, string fioPassenger, string passport)
        {
            List<Ticket> ticketList = null;
            int pageSize = 30;
            int pageNumber = (page ?? 1);

            if (fioPassenger != null && !fioPassenger.Equals("") && passport != null && !passport.Equals(""))
            {
                ticketList = db.Tickets.Where(f => fioPassenger.Contains(fioPassenger)).
                                        Where(p => p.Passport.Contains(passport)).ToList();
                ViewBag.FIOPassenger = fioPassenger;
                ViewBag.Passport = passport;
            }
            else if (fioPassenger != null && !fioPassenger.Equals(""))
            {
                ticketList = db.Tickets.Where(f => f.FIOPassenger.Contains(fioPassenger)).ToList();
                ViewBag.FIOPassenger = fioPassenger;
            }
            else if (passport != null && !passport.Equals(""))
            {
                ticketList = db.Tickets.Where(p => p.Passport.Contains(passport)).ToList();
                ViewBag.Passport = passport;
            }
            else
            {
                ticketList = db.Tickets.ToList();
            }

            return View(ticketList.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Create()
        {
            ViewBag.Flights = new SelectList(db.Flights.Select(s => new
            {
                Id = s.Id,
                Description = s.DeparturePoint + " - " + s.Destination
            }), "Id", "Description");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            if(ModelState.IsValid)
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult SelectedFlight(int id)
        {
            var flight = db.Flights.Find(id);

            return PartialView(flight);
        }

        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var ticket = db.Tickets.Find(id);

                ViewBag.Flights = new SelectList(db.Flights.Select(s => new
                {
                    Id = s.Id,
                    Description = s.DeparturePoint + " - " + s.Destination
                }), "Id", "Description");

                return View(ticket);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                db.Tickets.Update(ticket);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var ticket = db.Tickets.Find(id);
                if (ticket != null)
                {
                    db.Tickets.Remove(ticket);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}