using MVC_Dashboard_Login.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard_Login.Areas.Member.Controllers
{
    [AuthMemberFilter]
    [AuthFilter]
    public class HomeController : Controller
    {
        // GET: Member/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult Shipper()
        {
            return View();
        }
    }
}