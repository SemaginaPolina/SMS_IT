using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DBModels
{
    public class Post
    {     

        [Key]
        public int Id { get; set; }

        [Display(Name = "Укажите изображение")]
        public string Img { get; set; }

        [Display(Name = "Введите имя")]
        public string Name { get; set; }

        [Display(Name = "Введите категорию")]
        public string Category { get; set; }

        [Display(Name = "Введите цену")]
        public decimal Price { get; set; }

        [Display(Name = "Введите цвет")]
        public string Color { get; set; }

        [Display(Name = "Введите размер")]
        public string Size { get; set; }

    }
}