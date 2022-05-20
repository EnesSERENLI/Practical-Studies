using MVC_Dashboard_Login.Models;
using MVC_Dashboard_Login.Utilities;
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
                        var callBackUrl = Url.Action("Activation", "Register", new {                            
                            UserName = appUser.UserName,
                            Id = db.AppUsers.Count()+1
                        });
                        db.AppUsers.Add(appUser);
                        db.SaveChanges();
                        MailSender.SendMail(appUser.Email,"Activation", "<h2>Merhaba!</h2> </hr> <p style='color:green'>Üyeliğinizi aktif hale getirebilmek için lütfen aşağıdaki linke tıklayınız..</p> </hr> https://localhost:44395" + callBackUrl);         
                        return RedirectToAction("Index", "Login");
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

        public ActionResult Activation(string UserName,int id)
        {
            AppUser appUser = db.AppUsers.Where(x => x.UserName == UserName).FirstOrDefault();
            appUser.ComfirmEmail = true;
            db.SaveChanges();
            return View();
        }
    }
}