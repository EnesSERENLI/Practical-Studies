using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi_CRUDs.Models;

namespace WebApi_CRUDs
{
    public static class WebApiConfig
    {       
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var cors = new EnableCorsAttribute("*", "*", "*"); //başka projelerde gelen istekler için..
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            //CustomRoute For Update
            config.Routes.MapHttpRoute(
                name: "UpdateEmployee",
                routeTemplate: "api/{controller}/{action}/{id}/{title}/{firstName}/{lastName}"
                );
            //CustomRoute For Add
            config.Routes.MapHttpRoute(
                name:"AddEmployee",
                routeTemplate: "api/{controller}/{action}/{title}/{firstName}/{lastName}"
                );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
