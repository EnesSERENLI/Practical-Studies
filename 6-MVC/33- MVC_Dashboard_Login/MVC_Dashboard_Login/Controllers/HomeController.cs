using MVC_Dashboard_Login.CustomFilters;
using MVC_Dashboard_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard_Login.Controllers
{
    [AuthFilter]
    public class HomeController : Controller
    {
        // GET: Home
        [MVC_Dashboard_Login.CustomFilters.ActionFilter]
        public ActionResult Index()
        {
            AppUser appUser = Session["login"] as AppUser;  
            return View(appUser);
        }
    }
}