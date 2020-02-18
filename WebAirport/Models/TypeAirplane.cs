using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models
{
    public class TypeAirplane
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: Название типа самолета")]
        [MaxLength(100)]
        public string NameType { get; set; }

        [Required(ErrorMessage = "Требуется поле: Назначение")]
        [MaxLength(100)]
        public string Appointment { get; set; }

        [Required(ErrorMessage = "Требуется поле: Ограничения")]
        public string Limitation { get; set; }

        public ICollection<Airplane> Airplane { get; set; }

        public IEnumerable<TypeAirplane> TypeAirplanes { get; set; }
    }
}