using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;
using WebAirport.Models;
using PagedList;
using System.Data.Entity;

namespace WebAirport.Controllers
{
    public class TicketController : Controller
    {
        private AirportContext db = new AirportContext();
        // GET: Ticket
        public ActionResult Index(int? page)
        {
            var listTicket = db.Tickets.ToList();
            int pageSize = 30;
            int pageNumber = (page ?? 1);


            return View(listTicket.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            ViewBag.Flights = new SelectList(db.Flights.Select(s => new
            {
                Id = s.Id,
                Description = s.DeparturePoint + " - " + s.Destination
            }), "Id", "Description");

            return View();
        }

        [HttpPost]
        public ActionResult Create(Ticket ticket)
        {
            db.Tickets.Add(ticket);
            db.SaveChanges();

            return null;
        }

        public ActionResult SelectedFlight(int id)
        {
            var flight = db.Flights.Find(id);

            return PartialView(flight);
        }

        public ActionResult Edit(int? id)
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
        public void Edit(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticket).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public ActionResult Delete(int? id)
        {
            if(id.HasValue)
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