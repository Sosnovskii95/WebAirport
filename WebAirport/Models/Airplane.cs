using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAirport.Models
{
    public class Airplane
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public int PessengerCapacity { get; set; } 
        
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public double CarryingCapacity { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public int TypeAirplaneId { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [MaxLength(50)]
        public string Specifications { get; set; }

        [Column(TypeName="date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public int FlyingHours { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public DateTime? LastRepairDate { get; set; }

        public ICollection<JobAirplane> JobAirplane { get; set; }
        public TypeAirplane TypeAirplane { get; set; }

        public IEnumerable<Airplane> Airplanes { get; set; }
    }
}