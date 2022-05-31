using Northwind_Api_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Northwind_Api_CRUD.Controllers
{
    public class OrderController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        public IHttpActionResult GetOrder()
        {
            var result = from o in db.Orders
                         select new
                         {
                            o.OrderID,
                            o.OrderDate,
                            Name = o.Employee.FirstName +" "+o.Employee.LastName,
                            o.ShipName,
                            o.Freight
                         };
            return Ok(result);
        }
    }
}

