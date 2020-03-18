using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAirport.Data;
using WebAirport.Models.CodeFirst;
using X.PagedList;

namespace WebAirport.Controllers
{
    public class FlightController : Controller
    {
        private AirportContext db;

        public FlightController(AirportContext context)
        {
            db = context;
        }

        public IActionResult Index(int? page, string departurePoint, string destination)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 30;
            List<Flight> flightList = null;

            if (departurePoint != null && destination != null && !departurePoint.Equals("") && !destination.Equals(""))
            {
                flightList = db.Flights.Where(d => d.DeparturePoint.Contains(departurePoint)).
                                        Where(p => p.Destination.Contains(destination)).ToList();
                ViewBag.destination = destination;
                ViewBag.departurePoint = departurePoint;
            }
            else if (departurePoint != null && !departurePoint.Equals(""))
            {
                flightList = db.Flights.Where(d => d.DeparturePoint.Contains(departurePoint)).ToList();
                ViewBag.departurePoint = departurePoint;
            }
            else if (destination != null && !destination.Equals(""))
            {
                flightList = db.Flights.Where(d => d.Destination.Contains(destination)).ToList();
                ViewBag.destination = destination;
            }
            else
            {
                flightList = db.Flights.ToList();
            }

            return View(flightList.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Create()
        {
            var typeAirplane = db.TypeAirplanes.First();
            ViewBag.TypeAirplane = new SelectList(db.TypeAirplanes, "Id", "NameType");
            ViewBag.Airplane = new SelectList(db.Airplanes.Where(t => t.TypeAirplaneId == typeAirplane.Id), "Id", "Model");
            ViewBag.Staff = new SelectList(db.Staffs, "Id", "FIOStaff");

            return View();
        }

        [HttpPost]
        public IActionResult ListAirplaneByType(int id)
        {
            var airplanes = db.Airplanes.Where(c => c.TypeAirplaneId == id).ToList();

            if (airplanes.Count <= 0)
            {
                return HttpNotFound();
            }

            return PartialView(airplanes);
        }

        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Create(Flight flight)
        {
            if (ModelState.IsValid)
            {
                db.Flights.Add(flight);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var flight = db.Flights.Include(p => p.JobAirplane).
                                    Where(i => i.Id == id).
                                    FirstOrDefault();


                int typeId = db.Airplanes.Where(t => t.Id == flight.JobAirplane.AirplaneId).
                                          Select(t => t.TypeAirplaneId).
                                          FirstOrDefault();

                ViewBag.Staffs = new SelectList(db.Staffs, "Id", "FIOStaff");
                ViewBag.TypeAirplane = new SelectList(db.TypeAirplanes, "Id", "NameType", typeId);
                ViewBag.Airplane = new SelectList(db.Airplanes.Where(i => i.TypeAirplaneId == typeId), "Id", "Model");
                return View(flight);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult getAirplaneType(int id)
        {
            return PartialView(db.Airplanes.Where(t => t.TypeAirplaneId == id).ToList());
        }

        [HttpPost]
        public IActionResult Edit(Flight flight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flight).State = EntityState.Modified;
                db.Entry(flight.JobAirplane).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var flight = db.Flights.Find(id);

                if (flight != null)
                {
                    if (db.Tickets.Where(i => i.FlightId == id).Count() > 0)
                    {
                        var ticketList = db.Tickets.Where(i => i.FlightId == id).ToList();
                        ViewBag.Flights = db.Flights.Select(s => new
                        {
                            Id = s.Id,
                            Description = s.DeparturePoint + " - " + s.Destination
                        }).ToList();//Список рейсов
                        ViewBag.currentFlight = flight;

                        return View(ticketList);
                    }
                    else
                    {
                        db.Flights.Remove(flight);
                        db.SaveChanges();
                    }
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int currentId, List<int> id, List<int> flightId)
        {
            if (id != null && flightId != null)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    if (flightId[i] != currentId)
                    {
                        var ticket = db.Tickets.Find(id[i]);

                        ticket.FlightId = flightId[i];
                        db.Entry(ticket).State = EntityState.Modified;
                    }
                }
                db.SaveChanges();
            }
            return RedirectToAction("Delete", new { currentId });
        }
    }
}