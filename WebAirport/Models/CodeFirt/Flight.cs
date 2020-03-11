using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models.CodeFirst
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: Дата полета")]
        public DateTime DateTimeFlight { get; set; }

        [Required(ErrorMessage = "Требуется поле: Пункт отправления")]
        [MaxLength(100)]
        public string DeparturePoint { get; set; }

        [Required(ErrorMessage = "Требуется поле: Пункт прибытия")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Требуется поле: ")]
        public int JobAirplaneId { get; set; }

        [Required(ErrorMessage = "Требуется поле: Время в полете")]
        public TimeSpan TimeInFlight { get; set; }

        public JobAirplane JobAirplane { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}