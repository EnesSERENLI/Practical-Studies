using BLL.EntityTypeRepository;
using DAL.Concrete;
using Presentation.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        public ActionResult Index()
        {           
            return View(productService.GetDefaults(x=>x.Status != DAL.Enums.Status.Deleted));
        }

        #region AddProduct
        public ActionResult AddProduct()
        {
            ViewBag.Categories = categoryService.GetDefaults(x => x.Status != DAL.Enums.Status.Deleted);
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(AddProductDTO model)
        {
            ViewBag.Categories = categoryService.GetDefaults(x => x.Status != DAL.Enums.Status.Deleted);
            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.ProductName = model.ProductName;
                product.Description = model.Description;
                product.UnitPrice = model.UnitPrice;
                product.UnitsInStock = model.UnitsInStock;
                product.CategoryId = model.CategoryId;

                TempData["message"] = productService.Add(product);
                return RedirectToAction("index");
            }
            return View(model);
        } 
        #endregion

        #region UpdateProduct
        public ActionResult Update(Guid id)
        {            
            var product = productService.GetById(id);
            if (product != null)
            {
                return View(product);
            }
            TempData["message"] = "Ürün bulunamadı!";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(UpdateProductDTO model)
        {
            ViewBag.Categories = categoryService.GetDefaults(x => x.Status != DAL.Enums.Status.Deleted);
            if (ModelState.IsValid)
            {
                var product = productService.GetById(model.ID);
                if (product != null)
                {
                    product.ProductName = model.ProductName;
                    product.Description = model.Description;
                    product.UnitPrice = model.UnitPrice;
                    product.UnitsInStock = model.UnitsInStock;
                    TempData["message"] = productService.Update(product);
                    return RedirectToAction("index");
                }
            }
            return View(model);
        } 
        #endregion

        #region DeleteProduct
        public ActionResult Delete(Guid id)
        {
            var product = productService.GetById(id);
            if (product != null)
                productService.Delete(id);
            else
                return RedirectToAction("Index");
            return RedirectToAction("Index");
        } 
        #endregion
    }
}