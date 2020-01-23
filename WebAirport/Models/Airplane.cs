using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAirport.Models
{
    public class Airplane
    {
        public int AirplaneId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        public int PessengerCapacity { get; set; } 
        
        [Required]
        public double CarryingCapacity { get; set; }

        public int JobAirplaneId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Specifications { get; set; }

        [Column(TypeName="date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public double FlyingHours { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime LastRepairDate { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public JobAirplane JobAirplane { get; set; }
    }
}