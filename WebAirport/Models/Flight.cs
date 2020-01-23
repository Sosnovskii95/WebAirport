using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAirport.Models
{
    public class Flight
    {
        public int FlightId { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DateFlight { get; set; }

        [Required]
        [MaxLength(100)]
        public string DeparturePoint { get; set; }

        [Required]
        public double Destination { get; set; }

        public int AirplaneId { get; set; }

        [Required]
        public double TimeFlight { get; set; }

        public Airplane Airplane { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}