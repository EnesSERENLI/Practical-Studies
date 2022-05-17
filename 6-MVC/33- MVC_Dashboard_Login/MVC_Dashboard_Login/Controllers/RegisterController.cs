using MVC_Dashboard_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard_Login.Controllers
{
    public class RegisterController : Controller
    {
        MVCFilterDBEntities db = new MVCFilterDBEntities();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (db.AppUsers.Any(x => x.UserName == appUser.UserName || x.Email == appUser.Email))
                    {
                        TempData["error"] = "Kullancı adı/Email zaten var!";
                        return View(appUser);
                    }
                    else
                    {
                        db.AppUsers.Add(appUser);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (Exception)
                {
                    return View();
                }
            }
            else
            {
                return View(appUser);
            }
        }
    }
}