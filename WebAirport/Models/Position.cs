using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAirport.Models
{
    public class Position
    {
        public int PositionId { get; set; }

        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        public string Responsibilities { get; set; }

        [Required]
        public string Requirements { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}