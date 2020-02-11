using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;
using WebAirport.Models;
using PagedList;

namespace WebAirport.Controllers
{
    public class TicketController : Controller
    {
        private AirportContext db = new AirportContext();
        // GET: Ticket
        public ActionResult Index(int ? page)
        {
            var listTicket = db.Tickets.ToList();
            int pageSize = 30;
            int pageNumber = (page ?? 1);


            return View(listTicket.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            ViewBag.Flights = db.Flights.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Ticket ticket)
        {
            db.Tickets.Add(ticket);
            db.SaveChanges();

            return null;
        }

        [HttpPost]
        public ActionResult SelectedFlight(int idFlight)
        {
            var flight = db.Flights.Find(idFlight);

            return PartialView(flight);
        }
    }
}