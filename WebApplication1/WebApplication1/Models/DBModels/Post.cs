﻿using System;
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

        public Guid Photo { get; set; }

        public string Text { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual User Author { get; set; }

    }
}