using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L14.Models
{
    public class PhoneModel
    {
        [Key, Phone, MaxLength(10, ErrorMessage = "Длина номера не должна превышать 10 символов"), Display(Name = "Телефон")]
        public string Phone { get; set; }
        [MaxLength(30, ErrorMessage = "Длина Фамилии не должна превышать 30 символов"), Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [MaxLength(30, ErrorMessage = "Длина Имени не должна превышать 30 символов"), Display(Name = "Имя")]
        public string Firstname { get; set; }
        [MaxLength(30, ErrorMessage = "Длина Отчества не должна превышать 30 символов"), Display(Name = "Отчество")]
        public string Middlename { get; set; }
        public DateTime BDay { get; set; }

        public PhoneModel() { }
        public PhoneModel(string phone, string surname, string firstname, string middlename, DateTime bDay)
        {
            Phone = phone;
            Surname = surname;
            Firstname = firstname;
            Middlename = middlename;
            BDay = bDay;
        }
    }
}
