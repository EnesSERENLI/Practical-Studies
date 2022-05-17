using MVC_Dashboard_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard_Login.Controllers
{
    public class LoginController : Controller
    {
        MVCFilterDBEntities db = new MVCFilterDBEntities();
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
                bool result = db.AppUsers.Any(x => x.UserName == loginUser.UserName && x.Password == loginUser.Password);
                if (result)
                {
                    AppUser appUser = db.AppUsers.Where(x => x.UserName == loginUser.UserName).FirstOrDefault();
                    Session["login"] = appUser;
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