using System.Data.Entity;
using WebApplication1.Models.DBModels;

namespace WebApplication1.DAL
{
    public class SurfDBInitializer : DropCreateDatabaseAlways<SurfDbContext>
    {
        protected override void Seed(SurfDbContext context)
        {
            var user = new User
            {
                Nickname = "clame",
                LastName = "Бойков",
                Name = "Володя",
                Email = "clame@gmail.com",
                About = "Я такой хороший"
            };

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}