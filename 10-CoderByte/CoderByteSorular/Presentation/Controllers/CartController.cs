using BLL.EntityTypeRepository;
using DAL.Concrete;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class CartController : Controller
    {
        ProductService productService = new ProductService();
        OrderService orderService = new OrderService();
        OrderDetailService OrderDetailService = new OrderDetailService();
        public ActionResult Index()
        {
            if (Session["scart"] != null)
            {
                return View();
            }
            else
            {
                TempData["error"] = "sepetinizde ürün bulunmamaktadır!";
                return View();
            }
        }

        public ActionResult AddToCart(Guid id)
        {
            try
            {
                Product product = productService.GetById(id);
                Cart c = Session["scart"] == null ? new Cart() : Session["scart"] as Cart;

                CartItem ci = new CartItem();
                ci.Id = product.ID;
                ci.Price = product.UnitPrice;
                ci.ProductName = product.ProductName;
                ci.OrderDate = DateTime.Now.Date;
                c.AddItem(ci);
                Session["scart"] = c;
                return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public ActionResult Increase(Guid id)
        {
            Cart cart = Session["scart"] as Cart;
            foreach (var item in cart.myCart)
            {
                if (item.Id == id)
                {
                    item.Quantity++;
                    break;
                }
            }
            return RedirectToAction("Index", "Cart");
        }

        public ActionResult Decrease(Guid id)
        {
            Cart cart = Session["scart"] as Cart;
            foreach (var item in cart.myCart)
            {
                if (item.Id == id)
                {
                    item.Quantity--;
                    break;
                }
            }
            return RedirectToAction("Index", "Cart");
        }

        public ActionResult ComplateCart() //Order Complate
        {
            Cart cart = Session["scart"] as Cart;
            //AppUser user = Session["login"] as AppUser;
            Order order = new Order();
            order.OrderDate = DateTime.Now.Date;
            orderService.Add(order);
            if (cart != null)
            {
                foreach (var item in cart.myCart)
                {
                    Product product = productService.GetById(item.Id);
                    product.UnitsInStock -= Convert.ToInt16(item.Quantity);
                    productService.Update(product);

                    
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderId = order.ID;
                    orderDetail.ProductId = item.Id;
                    orderDetail.UnitPrice = item.Price;
                    orderDetail.Quantity = item.Quantity;
                    orderDetail.SubTotal = item.SubTotal;
                    OrderDetailService.Add(orderDetail);
                }
                Session.Remove("scart"); 
            }
            return View();
        }
    }
}