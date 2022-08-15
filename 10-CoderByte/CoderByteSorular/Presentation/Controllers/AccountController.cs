using BLL.EntityTypeRepository;
using DAL.Concrete;
using Presentation.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Presentation.Controllers
{
    public class AccountController : Controller
    {
        AppUserService appUserService = new AppUserService();

        #region Login
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                bool result = appUserService.Any(x => x.UserName == model.UserName && x.Password == model.Password);
                if (result)
                {
                    AppUser user = appUserService.GetDefaults(x => x.UserName == model.UserName).FirstOrDefault();
                    FormsAuthentication.SetAuthCookie(user.UserName, true); //create cookies
                    Session["login"] = user;
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    TempData["error"] = $"Username/Password is incorrect. Please check your information..";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
        #endregion

        #region Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = appUserService.Any(x => x.UserName == model.UserName || x.Email == model.Email);
                if (result)
                {
                    TempData["info"] = "This User already exist!";
                    return View();
                }
                else
                {
                    AppUser user = new AppUser();
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.Password = model.Password;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.ConfirmPassword = model.ConfirmPassword;
                    var message = appUserService.Add(user);
                    TempData["info"] = message;

                    return RedirectToAction("SignIn");
                }
            }
            else
            {
                return View(model);
            }
        } 
        #endregion
    }
}