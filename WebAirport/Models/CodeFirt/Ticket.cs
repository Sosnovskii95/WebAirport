using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models.CodeFirst
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: ФИО")]
        [MaxLength(50)]
        public string FIOPassenger { get; set; }

        [Required(ErrorMessage = "Требуется поле: Пасспортные данные")]
        [MaxLength(100)]
        public string Passport { get; set; }

        [Required(ErrorMessage = "Требуется поле: Должность")]
        [MaxLength(100)]
        public string PositionPassenger { get; set; }

        [Required(ErrorMessage = "Требуется поле: Место в самолете")]
        public int Seat { get; set; }

        public int FlightId { get; set; }

        [Required(ErrorMessage = "Требуется поле: Стоимость")]
        public double Price { get; set; }

        public Flight Flight { get; set; }
    }
}