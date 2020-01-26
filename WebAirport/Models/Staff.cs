using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAirport.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstNameStaff { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastNameStaff { get; set; }

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Telephone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Passport { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public ICollection<JobAirplane> JobAirplanes { get; set; }
    }
}