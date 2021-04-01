using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DBModels
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public virtual User NameUser { get; set; }

        public virtual Product Category { get; set; }

        public virtual Product Price { get; set; }

        public virtual Product Color { get; set; }

        public virtual Product Name { get; set; }
    }
}