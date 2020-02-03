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
        public int Id { get; set; }

        [Required]
        public DateTime DateTimeFlight { get; set; }

        [Required]
        [MaxLength(100)]
        public string DeparturePoint { get; set; }

        [Required]
        public string Destination { get; set; }

        public int JobAirplaneId { get; set; }

        [Required]
        public TimeSpan TimeInFlight { get; set; }

        public JobAirplane JobAirplane { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public IEnumerable<Flight> flights { get; set; }
    }
}