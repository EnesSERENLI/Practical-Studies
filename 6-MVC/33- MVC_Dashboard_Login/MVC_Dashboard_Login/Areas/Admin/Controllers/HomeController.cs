using MVC_Dashboard_Login.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard_Login.Areas.Admin.Controllers
{
    [AuthAdminFilter]
    [AuthFilter]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult Supplier()
        {
            return View();
        }
    }
}