using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models.CodeFirst
{
    public class JobAirplane
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: Самолет")]
        public int AirplaneId { get; set; }

        [Required]
        public int StaffId { get; set; }

        public Staff Staff { get; set; }

        public Airplane Airplane { get; set; }

        public ICollection<Flight> Flight { get; set; }

    }
}