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
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public DateTime DateTimeFlight { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [MaxLength(100)]
        public string DeparturePoint { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public int JobAirplaneId { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public TimeSpan TimeInFlight { get; set; }

        public JobAirplane JobAirplane { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public IEnumerable<Flight> flights { get; set; }
    }
}