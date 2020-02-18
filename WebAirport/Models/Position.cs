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
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: Название должости")]
        [MaxLength(100)]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Требуется поле: Оплата")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Требуется поле: Обязанности")]
        public string Responsibilities { get; set; }

        [Required(ErrorMessage = "Требуется поле: Требования")]
        public string Requirements { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}