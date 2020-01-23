using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAirport.Models
{
    public class JobAirplane
    {
        public int JobAirplaneId { get; set; }

        public int TypeAirplaneId { get; set; }

        public int StaffId { get; set; }

        public Staff Staff { get; set; }

        public TypeAirplane TypeAirplane { get; set; }

        public ICollection<Airplane> Airplanes { get; set; }
    }
}