﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.DAL;
using WebApplication1.Helpers;
using WebApplication1.Models.DBModels;

namespace WebApplication1.Controllers
{
    public class RegisterController : Controller
    {
        SurfDbContext dbContext = new SurfDbContext();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register(User model, HttpPostedFileBase imageData)
        {
            if (ModelState.IsValid)
            {
                if(model.Password != model.PasswordConfirm)
                {
                    ModelState.AddModelError(string.Empty, "Введенные пароли не совпадают");
                    return View("Index", model);
                }
                var userInDb = dbContext.Users.FirstOrDefault(c => c.Nickname == model.Nickname);
                if( userInDb != null)
                {
                    ModelState.AddModelError(string.Empty, "Пользователь с таким псевдонимом уже существует");
                    return View("Index", model);
                }

                var userEmailDb = dbContext.Users.FirstOrDefault(c => c.Email == model.Email);
                if (userEmailDb != null)
                {
                    ModelState.AddModelError(string.Empty, "Пользователь с такой почтой уже существует");
                    return View("Index", model);
                }

                if (imageData!= null)
                {
                    model.Photo = ImageSaveHelper.SaveImage(imageData);
                }
                dbContext.Users.Add(model);
                dbContext.SaveChanges();

                FormsAuthentication.SetAuthCookie(model.Nickname, false);
                Session["UserId"] = model.Id.ToString();
                Session["Nickname"] = model.Nickname;
                Session["Photo"] = ImageUrlHelper.GetUrl(model.Photo);

                return RedirectToAction("Index", "Feed");
            }
            
            return View("Index", model);
        }
    }
}