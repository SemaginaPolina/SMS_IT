using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class LoginViewModel
    {
        [Display (Name = "Почта"), MaxLength(20)]
        [Required(ErrorMessage ="Ошибка в почте")]
        public string Email { get; set; }

        [Display(Name = "Пароль"), MaxLength(20)]
        [Required(ErrorMessage = "Ошибка в пароле")]
        public string Password { get; set; }

        [Display(Name = "Запомнить пароль")]
        public bool RememberMe { get; set; }
    }
}