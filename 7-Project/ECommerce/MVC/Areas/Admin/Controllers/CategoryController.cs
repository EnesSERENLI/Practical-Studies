using DataAccess.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin")]
    public class CategoryController : Controller
    {
        CategoryService categoryService = new CategoryService();
        // GET: Admin/Category
        public ActionResult Index()
        {
            ViewBag.ProductCount = categoryService;
            return View(categoryService.GetList());
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            try
            {
                bool result = categoryService.Any(x => x.CategoryName == category.CategoryName);
                if (result)
                {
                    TempData["message"] = "Bu category zaten mevcut!";
                    return View(category);
                }
                else
                {
                    TempData["message"] = categoryService.Add(category);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return View();
            }
        }

        public ActionResult DeleteCategory(Guid id)
        {
            try
            {
                TempData["message"] = categoryService.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
        public ActionResult DeleteForceCategory(Guid id)
        {
            var deleted = categoryService.GetById(id);
            try
            {
                TempData["message"] = categoryService.RemoveForce(deleted);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult UpdateCategory(Guid id)
        {
            var updated = categoryService.GetById(id);
            return View(updated);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            try
            {
                TempData["message"] = categoryService.Update(category);
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