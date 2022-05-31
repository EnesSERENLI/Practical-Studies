using Northwind_Api_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Northwind_Api_CRUD.Controllers
{
    public class CustomerController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        public HttpResponseMessage GetCustomer()
        {
            var result = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName,
                x.Phone,
                x.Address
            });
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }
    }
}
