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
        [Range(0, int.MaxValue, ErrorMessage ="Место в багажном отсеке?)")]
        public int Seat { get; set; }

        public int FlightId { get; set; }

        [Required(ErrorMessage = "Требуется поле: Стоимость")]
        [Range(0, int.MaxValue, ErrorMessage ="Стоимость не может быть отрицательной")]
        public int Price { get; set; }

        public Flight Flight { get; set; }
    }
}