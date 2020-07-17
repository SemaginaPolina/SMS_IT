using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DBModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Никнейм
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Контактная информация
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// О себе
        /// </summary>
        public string About { get; set; }
        /// <summary>
        /// Достижения
        /// </summary>
        public string Achievements { get; set; }
        
        public Guid Photo { get; set; }
    }
}