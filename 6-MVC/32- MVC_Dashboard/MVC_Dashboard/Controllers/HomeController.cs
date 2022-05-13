using MVC_Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
       
        
        // GET: Home
        public ActionResult Index()
        {
            var result1 = db.Products.Count(); //Toplam ürün sayısı
            ViewBag.ProductCount = result1;

            var result2 = db.Employees.Count(); //Toplam Çalışan sayısı
            ViewBag.EmployeeCount = result2;

            var result3 = db.Orders.Count(); //Toplam Sipariş sayısı
            ViewBag.OrderCount = result3;

            var result4 = db.Customers.Count(); //Toplam Müşteri sayısı
            ViewBag.CustomerCount = result4;

            TempData["Orders"] = db.Orders.ToList(); //Bütün siparişler
            TempData.Keep();
            return View();
        }

        public ActionResult Details(int id)
        {
            var result = db.Order_Details.FirstOrDefault(x=>x.OrderID == id);   
            return View(result);
        }
    }
}