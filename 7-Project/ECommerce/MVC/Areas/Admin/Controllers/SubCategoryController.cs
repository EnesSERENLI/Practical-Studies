using DataAccess.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryService subCategoryService = new SubCategoryService();
        // GET: Admin/SubCategory
        public ActionResult Index()
        {
            return View(subCategoryService.GetList());
        }
        public ActionResult AddSubCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSubCategory(SubCategory subCategory)
        {
            try
            {
                bool result = subCategoryService.Any(x => x.ID == subCategory.ID);
                if (result)
                {
                    TempData["message"] = "Bu Subcategory zaten mevcut!";
                    return View(subCategory);
                }
                else
                {
                    TempData["message"] = subCategoryService.Add(subCategory);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return View();
            }
        }

        public ActionResult DeleteSubCategory(Guid id)
        {
            try
            {
                TempData["message"] = subCategoryService.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
        public ActionResult DeleteForceSubCategory(Guid id)
        {
            var deleted = subCategoryService.GetById(id);
            try
            {
                TempData["message"] = subCategoryService.RemoveForce(deleted);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult UpdateSubCategory(Guid id)
        {
            var updated = subCategoryService.GetById(id);
            return View(updated);
        }
        [HttpPost]
        public ActionResult UpdateSubCategory(SubCategory subCategory)
        {
            try
            {
                TempData["message"] = subCategoryService.Update(subCategory);
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