using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAirport.Data;
using WebAirport.Models;

namespace WebAirport.Controllers
{
    public class TicketController : Controller
    {
        private AirportContext db = new AirportContext();
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
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

        public ActionResult ListTicket()
        {
            var flights = db.Flights.ToList();

            return View(flights);
        }

        [HttpPost]
        public ActionResult ListTickets(int idFlight)
        {
            var tickets = db.Tickets.Where(c => c.FlightId == idFlight).ToList();

            return PartialView(tickets);
        }

        [HttpPost]
        public ActionResult SelectedFlight(int idFlight)
        {
            var flight = db.Flights.Find(idFlight);

            return PartialView(flight);
        }
    }
}