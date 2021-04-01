using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Helpers;
using WebApplication1.Models.DBModels;

namespace WebApplication1.Controllers
{
    public class CatalogController : Controller
    {
        private SurfDbContext dbContext = new SurfDbContext();

        // GET: Catalog новая версия
        public ActionResult Index()
        {

            var colorsDb = dbContext.Posts.OrderBy(post => post.Color).Select(post => post.Color).Distinct().ToArray();
            var catigoriesDb = dbContext.Posts.OrderBy(post => post.Category).Select(post => post.Category).Distinct().ToArray();

            ViewBag.Posts = dbContext.Posts.ToList();
            var colors = new SelectList(colorsDb);
            ViewBag.Colors = colorsDb;
            ViewBag.Catigories = catigoriesDb;
            return View();
        }

        [HttpPost]
        public string AjaxProducs(string cat, string color)
        {
            Post model = new Post();

            model.Category = cat;
            model.Color = color;

            string res = "";

            List<Post> posts = null;
            if (model.Category != "" && model.Color != "")
            {
                posts = dbContext.Posts.Where(c => c.Category == model.Category && c.Color == model.Color).ToList();
                foreach (Post post in posts)
                {
                    res += "<div class=\"col-sm-4\"><div class=\"product\"><div class=\"product-img\" style=\"display: block;  width: 210px; height: 210px; overflow:hidden;\"><a href = \"#\" ><img src=\"" + post.Img + "\" alt=\"\"></a></div><p class=\"product-title\">" + post.Name + "</p><p class=\"product-desc\">" + post.Price + "</p></div></div>";
                }
                return res;
            }

            if (model.Category != "")
            {
                posts = dbContext.Posts.Where(c => c.Category == model.Category).ToList();
                foreach (Post post in posts)
                {
                    res += "<div class=\"col-sm-4\"><div class=\"product\"><div class=\"product-img\" style=\"display: block;  width: 210px; height: 210px; overflow:hidden;\"><a href = \"#\" ><img src=\"" + post.Img + "\" alt=\"\"></a></div><p class=\"product-title\">" + post.Name + "</p><p class=\"product-desc\">" + post.Price + "</p></div></div>";
                }
                return res;
            }

            if (model.Color != "")
            {
                posts = dbContext.Posts.Where(c => c.Color == model.Color).ToList();
                foreach (Post post in posts)
                {
                    res += "<div class=\"col-sm-4\"><div class=\"product\"><div class=\"product-img\" style=\"display: block;  width: 210px; height: 210px; overflow:hidden;\"><a href = \"#\" ><img src=\"" + post.Img + "\" alt=\"\"></a></div><p class=\"product-title\">" + post.Name + "</p><p class=\"product-desc\">" + post.Price + "</p><a href=\"/Seller/Index\">Купить</a></div></div>";
                }
                return res;
            }
            return "NULL";
        }
    }
}