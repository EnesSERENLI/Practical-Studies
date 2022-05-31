using Northwind_Api_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Northwind_Api_CRUD.Controllers
{
    public class HomeController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        public IHttpActionResult GetProduct()
        {
            var result = from p in db.Products select new
            {
                p.ProductID,
                p.ProductName,
                p.Category.CategoryName,
                p.UnitPrice,
                p.UnitsInStock
            };
            return Ok(result);
        }

        public HttpResponseMessage GetProductById(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
            {
                string categoryName = product.CategoryID == null ? "Category Yok" : product.Category.CategoryName;
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK,product.ProductID+" "+product.ProductName+" "+categoryName+" "+product.UnitPrice+" "+product.UnitsInStock );
                return response; 
            }
            else
            {
                HttpResponseMessage errorResponce = Request.CreateErrorResponse(HttpStatusCode.NotFound, "ürün bulunamadı!");
                return errorResponce;
            }
        }

        public IHttpActionResult PostProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Ok(product.ProductName + " veri tabanına eklendi!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public HttpResponseMessage PutProduct(Product product)
        {
            Product updated = db.Products.FirstOrDefault(x=>x.ProductID == product.ProductID);
            if (updated != null)
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, product.ProductName + " güncellendi!");
                return response;
            }
            else
            {
                HttpResponseMessage errorResponse = Request.CreateErrorResponse(HttpStatusCode.NotFound, product.ProductName + " bulunamadı!");
                return errorResponse;
            }
        }

        public IHttpActionResult DeleteProduct(int id)
        {
            Product deleted = db.Products.Find(id);
            if (deleted != null)
            {
                try
                {
                    db.Products.Remove(deleted);
                    db.SaveChanges();
                    return Ok("Veri silindi");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return BadRequest("Böyle bir ürün yok!");
            }
        }
    }
}
