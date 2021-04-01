using System.Data.Entity;
using System;
using WebApplication1.Models.DBModels;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DAL
{
    public class SurfDBInitializer : //DropCreateDatabaseAlways<SurfDbContext>
        DropCreateDatabaseIfModelChanges<SurfDbContext>
    {
        
        protected override void Seed(SurfDbContext context)
        {
            var product = new Post
            {
                Name = "Роликовые коньки Flying Eagle F5 Eclipse",
                Img = "https://rollbay.ru/image/cache/catalog/img/skates/fe_f5_black-400x400.jpg",
                Category = "Ролики",
                Price = 12300,
                Color = "Черные",
                Size = "37"
            };


            var user = new User
            {
                Name = "Володя",
                Email = "clame@gmail.com",
                Address = "Я такой хороший",
                Contact = "89277538844"
            };

            var post1 = new Post
            {
                Name = "КОНЬКИ ФИГУРНЫЕ EDEA CHORUS",
                Img = "https://www.twizzle.ru/upload/iblock/15e/15e548d8fea254f1e239d793314edfa3.jpg",
                Category = "Коньки",
                Price = 20950,
                Color = "Черные",
                Size = "37"
            };

            var post2 = new Post
            {
                Name = "Детские роликовые коньки Flying Eagle Drift Junior",
                Img = "https://rollbay.ru/image/cache/catalog/img/skates/fe_jr_blue-400x400.jpg",
                Category = "Ролики",
                Price = 123,
                Color = "Синий",
                Size = "37"
            };

            var post3 = new Post
            {
                Name = "Роликовые коньки Flying Eagle F6S Falcon",
                Img = "https://rollbay.ru/image/cache/catalog/img/skates/fe_f6_green-400x400.jpg",
                Category = "Ролики",
                Price = 18900,
                Color = "Черные",
                Size = "37"
            };

            var post4 = new Post
            {
                Name = "W03331G-FF172 КОСТЮМ УТЕПЛЕННЫЙ ЖЕНСКИЙ",
                Img = "https://www.forward-sport.ru/upload/resize_cache/iblock/a40/576_865_1/a4078fabcdeda95cdae58667e5b40e04.jpg",
                Category = "Экипировка",
                Price = 16000,
                Color = "Красный",
                Size = "37"
            };

            var post5 = new Post
            {
                Name = "Детские роликовые коньки Flying Eagle S6S",
                Img = "https://rollbay.ru/image/cache/catalog/img/skates/fe_s6s_pink-400x400.jpg",
                Category = "Ролики",
                Price = 7800,
                Color = "Розовые",
                Size = "35"
            };

            var post6 = new Post
            {
                Name = "W01340G-СN201 КОСТЮМ ПАРАДНЫЙ ЖЕНСКИЙ",
                Img = "https://www.forward-sport.ru/upload/resize_cache/iblock/0bd/576_865_1/0bd61b9e8f514ace78f05f57d266f23a.jpg",
                Category = "Экипировка",
                Price = 8900,
                Color = "Red",
                Size = ""
            };

            var post7 = new Post
            {
                Name = "КОНЬКИ ФИГУРНЫЕ EDEA ICE FLY",
                Img = "https://www.twizzle.ru/upload/iblock/ac8/ac8afee6e117ff9c9f2833132d37af92.jpg",
                Category = "Коньки",
                Price = 38500,
                Color = "Белые",
                Size = "37"
            };
            var post8 = new Post
            {
                Name = "КОНЬКИ ФИГУРНЫЕ EDEA PIANO",
                Img = "https://www.twizzle.ru/upload/iblock/ced/ced31a6fb4f67c62be411b5009d4538f.jpg",
                Category = "Коньки",
                Price = 39000,
                Color = "Черные",
                Size = "37"
            };
            var post9 = new Post
            {
                Name = "Роликовые коньки Powerslide Evo Trinity Pro",
                Img = "https://rollbay.ru/image/cache/catalog/powerslide/1558100577894-400x400.jpg",
                Category = "Ролики",
                Price = 43000,
                Color = "Черные",
                Size = "39"
            };

            context.Users.Add(user);
            context.Posts.Add(post1);
            context.Posts.Add(post2);
            context.Posts.Add(post3);
            context.Posts.Add(post4);
            context.Posts.Add(post5);
            context.Posts.Add(post6);
            context.Posts.Add(post7);
            context.Posts.Add(post8);
            context.Posts.Add(post9);
            context.Posts.Add(product);
            context.SaveChanges();
        }
    }
}