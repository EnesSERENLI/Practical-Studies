using Common;
using DataAccess.Entity;
using MVC.Models;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        AppUserService appUserService = new AppUserService();
        ProductService productService = new ProductService();
        public ActionResult Index()
        {
            return View(productService.GetDefault(x=>x.Status == Core.Enums.Status.Active));  
        }
        //Register
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                appUser.Email = appUserVM.Email;
                appUser.Password = appUserVM.Password;
                appUser.UserName = appUserVM.UserName;
                appUser.ActivationCode = Guid.NewGuid();
                var result = appUserService.Add(appUser);
                TempData["info"]=result;

                //MailSender
                MailSender.SendMail(appUser.Email,"Üyelik Aktivasyon",$"üyeliğinizi aktif hale getirebilmek için linki tıklayın https://localhost:44318/Home/Activation/" + appUser.ActivationCode);
                return RedirectToAction("Pending");
            }
            else
            {
                return View(appUserVM);
            }
        }
        
        public ActionResult Pending(AppUser appUser)
        {
            if (appUser != null)
            {
                return View(appUser);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        //Activation
        public ActionResult Activation(Guid id)
        {
            if (id != null)
            {
                AppUser user = appUserService.GetDefault(x => x.ActivationCode == id).FirstOrDefault();
                user.IsActive = true;
                appUserService.Update(user);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Register");
            }
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginUser loginUser)
        {
            if (ModelState.IsValid)
            {
                bool result = appUserService.Any(x=>x.UserName == loginUser.UserName && x.Password == loginUser.Password);
                if (result)
                {
                    AppUser user = appUserService.GetDefault(x => x.UserName == loginUser.UserName).FirstOrDefault();
                    FormsAuthentication.SetAuthCookie(user.UserName, true);
                    Session["login"] = user; //Cookiesler den çekince buna gerek kalmayacak..
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["error"] = $"Kullanıcı adı/Şifre yanlış. Lütfen bilgilerinizi kontrol ediniz..";
                    return View(loginUser);
                }                
            }
            else
            {
                return View(loginUser);
            }
        }
        public ActionResult AddToCart(Guid id)
        {
            try
            {
                Product product = productService.GetById(id);

                Cart c = null;

                if (Session["scart"] == null)
                {
                    c = new Cart();
                }
                else
                {
                    c = Session["scart"] as Cart;
                }

                //Cart c = Session["scart"] == null ? new Cart() : Session["scart"] as Cart;

                CartItem ci = new CartItem();
                ci.Id = product.ID;
                ci.Price = product.UnitPrice;
                ci.ProductName = product.ProductName;
                c.AddItem(ci);
                Session["scart"] = c;

                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                TempData["error"] = $"{id} karşılık gelen bir ürün bulunamadı!";
                return View();

            }

        }
        public ActionResult MyCart()
        {
            if (Session["scart"] != null)
            {
                return View();
            }
            else
            {
                TempData["error"] = "sepetinizde ürün bulunmamaktadır!";
                return RedirectToAction("Index");
            }

        }

        [Authorize(Roles = "admin,moderator,member")]
        public ActionResult ComplateCart() //Siparişi tamamla
        {
            Cart cart = Session["scart"] as Cart;
            AppUser user = Session["login"] as AppUser; //Cookiesler den çekince gerek kalmayacak..
            foreach (var item in cart.myCart)
            {
                Product product = productService.GetById(item.Id);
                product.UnitInStock -= Convert.ToInt16(item.Quantity);
                productService.Update(product);

            }
            Random rnd = new Random();
            ViewBag.OrderNumber = rnd.Next(100000, 1000000);
            string message = $"<h2 style='color:green'>Merhaba</h2> </br> <h2><strong>{ViewBag.OrderNumber}</strong></h2> numaralı siparişini aldık. Siparişiniz en kısa sürede teslim edilmek üzere yola çıkacaktır.";
            MailSender.SendMail(user.Email, "Sipariş Bilgilendirme", message);
            Session.Remove("scart");
            return View();
        }
    }

}
