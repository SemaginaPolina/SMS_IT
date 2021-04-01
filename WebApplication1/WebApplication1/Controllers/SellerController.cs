using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using System.Web.Security;
using WebApplication1.DAL;
using WebApplication1.Helpers;
using WebApplication1.Models.DBModels;

namespace WebApplication1.Controllers
{
    public class SellerController : Controller
    {
        SurfDbContext dbContext = new SurfDbContext();
        // GET: Seller
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(User model, HttpPostedFileBase imageData)
        {
            if (ModelState.IsValid)
            {
                dbContext.Users.Add(model);
                dbContext.SaveChanges();                

                return RedirectToAction("Index", "Feed");
            }

            return View("Index", model);
        }
    }
}