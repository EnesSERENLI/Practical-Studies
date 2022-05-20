using MVC_Dashboard_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard_Login.CustomFilters
{
    public class AuthAdminFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            AppUser user = filterContext.HttpContext.Session["login"] as AppUser;
            if (user.UserName != "CreastFall")
            {
                filterContext.Controller.TempData["user"] = "Bu sayfayı görüntüleme yetkiniz yoktur!!";
                filterContext.Result = new RedirectResult("~/Home/Index");
            }
        }
    }
}