using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models.DBModels;

namespace WebApplication1.Controllers
{
    public class AddProductController : Controller
    {
        private SurfDbContext dbContext = new SurfDbContext();

        // GET: AddProduct
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPost(Post model)
        {
            if (!ModelState.IsValid)
            {
                var posts1 = dbContext.Posts.OrderByDescending(c => c.Id).ToList();
                ViewBag.Posts = posts1;
                return View("Index", model);
            }

            if(model.Category!= "Коньки" && model.Category != "Ролики" && model.Category != "Экипировка")
            {
                ModelState.AddModelError(string.Empty, "Введена не существующая категория");
                var posts1 = dbContext.Posts.OrderByDescending(c => c.Id).ToList();
                ViewBag.Posts = posts1;
                return View("Index", model);
            }

            if (model.Name == null && model.Category == null && model.Color == null && model.Img == null && model.Price == null)
            {
                ModelState.AddModelError(string.Empty, "Не введено обязательное поле");
                var posts1 = dbContext.Posts.OrderByDescending(c => c.Id).ToList();
                ViewBag.Posts = posts1;
                return View("Index", model);
            }

            dbContext.Posts.Add(model);
            dbContext.SaveChanges();

            ModelState.Clear();

            return View("Index");
        }
    }
}