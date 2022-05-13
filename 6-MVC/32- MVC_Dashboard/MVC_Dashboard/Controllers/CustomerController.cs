using MVC_Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.Customer = db.Customers.ToList();
            return View();
        }
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}