using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models.CodeFirst
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: Название должости")]
        [MaxLength(100)]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Требуется поле: Оплата")]
        [Range(0, int.MaxValue, ErrorMessage = "Оклад не может быть отрицательным")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Требуется поле: Обязанности")]
        public string Responsibilities { get; set; }

        [Required(ErrorMessage = "Требуется поле: Требования")]
        public string Requirements { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}