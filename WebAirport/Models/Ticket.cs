using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstNamePassenger { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastNamePassenger { get; set; }

        [Required]
        [MaxLength(100)]
        public string Passport { get; set; }

        [Required]
        [MaxLength(100)]
        public string PositionPassenger { get; set; }

        [Required]
        public int Seat { get; set; }

        public int FlightId { get; set; }

        [Required]
        public double Price { get; set; }

        public Flight Flight { get; set; }
    }
}