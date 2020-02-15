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

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [MaxLength(100)]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Responsibilities { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Requirements { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}