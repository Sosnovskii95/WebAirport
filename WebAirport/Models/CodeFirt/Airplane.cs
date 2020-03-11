using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAirport.Models.CodeFirst
{
    public class Airplane
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: Модель")]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required(ErrorMessage = "Требуется поле: Кол-во пассажиров")]
        public int PessengerCapacity { get; set; }

        [Required(ErrorMessage = "Требуется поле: Грузоподъемность")]
        public double CarryingCapacity { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public int TypeAirplaneId { get; set; }

        [Required(ErrorMessage = "Требуется поле: Спецификация")]
        [MaxLength(50)]
        public string Specifications { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Требуется поле: Дата изготовления")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Требуется поле: Часов налета")]
        public int FlyingHours { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Требуется поле: Дата последнего ремонта")]
        public DateTime? LastRepairDate { get; set; }

        public ICollection<JobAirplane> JobAirplane { get; set; }
        public TypeAirplane TypeAirplane { get; set; }
    }
}