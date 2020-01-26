using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models
{
    public class TypeAirplane
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameType { get; set; }

        [Required]
        [MaxLength(100)]
        public string Appointment { get; set; }

        [Required]
        public string Limitation { get; set; }

        public ICollection<JobAirplane> JobAirplanes { get; set; }
    }
}