using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAirport.Models
{
    public class JobAirplane
    {
        public int Id { get; set; }

        public int TypeAirplaneId { get; set; }

        public int StaffId { get; set; }

        public Staff Staff { get; set; }

        public Airplane Airplane { get; set; }

        public ICollection<Flight> Flight { get; set; }
    }
}