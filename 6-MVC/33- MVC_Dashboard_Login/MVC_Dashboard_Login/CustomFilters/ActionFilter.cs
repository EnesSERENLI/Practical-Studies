using MVC_Dashboard_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard_Login.CustomFilters
{
    public class ActionFilter : FilterAttribute, IActionFilter
    {
        MVCFilterDBEntities db = new MVCFilterDBEntities(); 
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            log.LogDate = DateTime.Now;
            AppUser user = filterContext.HttpContext.Session["login"] as AppUser;
            log.UserName = user.UserName;
            log.Description = user.UserName + " giriş yaptı..";
            db.Logs.Add(log);
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            log.LogDate = DateTime.Now;
            AppUser user = filterContext.HttpContext.Session["login"] as AppUser;
            log.UserName = user.UserName;
            log.Description = user.UserName + " giriş isteğinde bulundu..";
            db.Logs.Add(log);
            db.SaveChanges();
        }
    }
}