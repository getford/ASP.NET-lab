using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab14.Models
{
    public class User
    {
        [Key]
        public string id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Введите фамилию")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Введите отчество")]
        public string middleName { get; set; }

        [Required(ErrorMessage = "Введите дату рождения")]
        public DateTime Bday { get; set; }

        [Required(ErrorMessage = "Введите телефон")]
        public string phone { get; set; }
    }
}