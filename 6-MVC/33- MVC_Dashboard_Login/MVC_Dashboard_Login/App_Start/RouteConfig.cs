using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Dashboard_Login
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Custom Route
            routes.MapRoute(
                name: "AccountActivation",
                url: "Register/Activation/{UserName}/{Id}/ActivationLink",
                defaults: new
                {
                    controller="Register",
                    action = "Activation",
                    UserName = UrlParameter.Optional,
                    Id = UrlParameter.Optional
                }
                );

            routes.MapRoute(
                name: "Default",                
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"MVC_Dashboard_Login.Controllers"}
            );
             
        }
    }
}
