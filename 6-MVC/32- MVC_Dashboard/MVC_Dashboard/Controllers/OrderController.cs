using MVC_Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard.Controllers
{
    public class OrderController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        public List<Order> orderList = new List<Order>();
        // GET: Order
        public ActionResult Index()
        {
            foreach (Order o in db.Orders)
            {
                orderList.Add(o);   
            }
            return View(orderList);
        }
        public ActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}