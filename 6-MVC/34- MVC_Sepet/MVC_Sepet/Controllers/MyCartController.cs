using MVC_Sepet.CustomFilter;
using MVC_Sepet.Models;
using MVC_Sepet.Utilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sepet.Controllers
{
    public class MyCartController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: MyCart        
        public ActionResult Index() //Sipariş ekranına giriş
        {
            if (Session["scart"] != null)
            {
                Cart cart = Session["scart"] as Cart;
                return View(cart.myCart.ToList());
            }
            else
            {
                TempData["error"] = "sepetinizde ürün bulunmamaktadır.";
                return RedirectToAction("Index", "Home");
            }
        }
        [AuthFilter] // Giriş yapılmamışsa sipariş tamamlanamayacak
        public ActionResult ComplateCart() //Siparişi tamamla
        {
            Cart cart = Session["scart"] as Cart;
            User user = Session["login"] as User;
            foreach (var item in cart.myCart)
            {
                Product product = db.Products.Find(item.Id);
                product.UnitsInStock -= Convert.ToInt16(item.Quantity);
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            Random rnd = new Random();
            ViewBag.OrderNumber = rnd.Next(100000, 1000000);
            string message = $"<h2 style='color:green'>Merhaba</h2> </br> <h2><strong>{ViewBag.OrderNumber}</strong></h2> numaralı siparişini aldık. Siparişiniz en kısa sürede teslim edilmek üzere yola çıkacaktır.";
            MailSender.OrderMail(user.Email,"Sipariş Bilgilendirme",message);
            Session.Remove("scart");
            return View();
        }
    }
}