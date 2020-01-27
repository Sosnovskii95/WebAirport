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
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        public int PessengerCapacity { get; set; } 
        
        [Required]
        public double CarryingCapacity { get; set; }

        public int TypeAirplaneId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Specifications { get; set; }

        [Column(TypeName="date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public double FlyingHours { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? LastRepairDate { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public TypeAirplane TypeAirplane { get; set; }

        public IEnumerable<Airplane> Airplanes { get; set; }
    }
}