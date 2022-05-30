using Common;
using DataAccess.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Common.ImageUploader;

namespace MVC.Areas.Admin.Controllers
{
    [Authorize(Roles ="moderator")]
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        SubCategoryService subCategoryService = new SubCategoryService();
        SupplierService supplierService = new SupplierService();
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View(productService.GetList());
        }

        public ActionResult AddProduct()
        {
            ViewBag.Supplier = supplierService.GetDefault(x=>x.Status == Core.Enums.Status.Active);
            ViewBag.SubCategories = subCategoryService.GetDefault(x=>x.Status == Core.Enums.Status.Active);
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product, HttpPostedFileBase fileImage)
        {
            //todo: her veri kaydedildiğinde fotoğraf eklenecek..
            try
            {
                
                bool result = productService.Any(x => x.ID == product.ID);
                if (result)
                {                    
                    TempData["message"] = "Bu product zaten mevcut!";
                    return View(product);
                }
                else
                {
                    product.ProductImagePath = ImageUploader.UploadImage("~/Content/image/product/", fileImage);
                    TempData["message"] = productService.Add(product);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return View();
            }
        }

        public ActionResult DeleteProduct(Guid id)
        {
            try
            {
                TempData["message"] = productService.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
        public ActionResult DeleteForceProduct(Guid id)
        {
            var deleted = productService.GetById(id);
            try
            {
                TempData["message"] = productService.RemoveForce(deleted);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult UpdateProduct(Guid id)
        {
            ViewBag.Supplier = supplierService.GetDefault(x => x.Status == Core.Enums.Status.Active);
            ViewBag.SubCategories = subCategoryService.GetDefault(x => x.Status == Core.Enums.Status.Active);
            var updated = productService.GetById(id);
            return View(updated);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            try
            {
                TempData["message"] = productService.Update(product);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return View();
            }
        }
    }
}