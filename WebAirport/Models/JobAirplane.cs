using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models
{
    public class JobAirplane
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AirplaneId { get; set; }

        [Required]
        public int StaffId { get; set; }

        public Staff Staff { get; set; }

        public Airplane Airplane { get; set; }

        public ICollection<Flight> Flight { get; set; }

        public IEnumerable<JobAirplane> JobAirplanes { get; set; }
    }
}