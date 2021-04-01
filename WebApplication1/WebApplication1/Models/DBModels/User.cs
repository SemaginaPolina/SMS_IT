using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DBModels
{
    //Заказ
    public class User
    {
        [Key]
        public int Id { get; set; }
        

        [Display(Name = "Почта*")]
        [Required(ErrorMessage = "Ввод электроной почты обязательнен!")]
        [EmailAddress(ErrorMessage ="Неверно указан электронный адрес")]
        public string Email { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Контактная информация")]
        public string Contact { get; set; }
    }
}