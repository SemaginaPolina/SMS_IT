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
    public class FeedController : Controller
    {

        private SurfDbContext dbContext = new SurfDbContext();
        // GET: Feed
        public ActionResult Index()
        {
            var posts = dbContext.Posts.OrderByDescending(c => c.Id).ToList();
            ViewBag.Posts = posts;

            return View();
        }

        
    }
}