using MVC_Sepet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sepet.Controllers
{
    public class LoginController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginUser loginUser)
        {
            if (ModelState.IsValid)
            {
                bool result = db.Users.Any(x=>x.Username == loginUser.UserName && x.Password == loginUser.Password);
                if (result)
                {
                    User user  = db.Users.Where(x=>x.Username == loginUser.UserName).FirstOrDefault();
                    Session["login"] = user;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["ErrorLogin"] = "Kullanıcı adı veya şifre yanlış!";
                    return View(loginUser);
                }
            }
            else
            {
                return View(loginUser);
            }
        }
    }
}