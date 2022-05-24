using MVC_Sepet.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC_Sepet.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Products.Where(x => x.CategoryID != null && x.UnitsInStock>0).ToList());
        }

        public ActionResult AddToCart(int id)
        {
            try
            {
                Product product = db.Products.Find(id);
                //Cart c = null;
                //if (Session["scart"] == null)
                //{
                //    c = new Cart();
                //}
                //else
                //{
                //    c = Session["scart"] as Cart;
                //}
                Cart c = Session["scart"] == null? new Cart() : Session["scart"] as Cart; //yukarıdaki işlemim aynısı.. 

                CartItem ci = new CartItem();
                ci.Id = product.ProductID;
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

        public ActionResult DeleteToCart(int id)
        {
            Cart cart = Session["scart"] as Cart;
            if (cart!=null)
            {
                cart.DeleteItem(id);
            }
            return RedirectToAction("Index","MyCart");
        }

        public ActionResult Increase(int id)
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
            return RedirectToAction("Index", "MyCart");
        }

        public ActionResult Decrease(int id)
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
            return RedirectToAction("Index", "MyCart");
        }
    }
}