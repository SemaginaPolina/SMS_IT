﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DBModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Псевдоним")]
        [Required(ErrorMessage ="Ошибка в псевдониме"), MinLength(3) ,MaxLength(20)]
        public string Nickname { get; set; }

        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Ввод электроной почты обязательнен!")]
        [EmailAddress(ErrorMessage ="Неверно указан электронный адрес")]
        public string Email { get; set; }


        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Ошибка в пароле"), MinLength(6), MaxLength(20)]
        public string Password { get; set; }

        [Display(Name = "Подтвердите пароль")]
        [NotMapped]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Контактная информация")]
        public string Contact { get; set; }

        [Display(Name = "О себе")]
        public string About { get; set; }

        [Display(Name = "Достижения")]
        public string Achievements { get; set; }

        [Display(Name = "Выберете фото")]
        public Guid Photo { get; set; }
    }
}