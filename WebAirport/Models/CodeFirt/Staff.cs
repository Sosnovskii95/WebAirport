using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAirport.Models.CodeFirst
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется поле: ФИО")]
        [MaxLength(100)]
        public string FIOStaff { get; set; }

        [Required(ErrorMessage = "Требуется поле: Пол")]
        [MaxLength(10)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Требуется поле: Адрес")]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Требуется поле: Номер телефона")]
        [MaxLength(50)]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Требуется поле: Пасспорт")]
        [MaxLength(100)]
        public string Passport { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public ICollection<JobAirplane> JobAirplanes { get; set; }
    }
}