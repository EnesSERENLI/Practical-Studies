using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi_Movies2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Custom Route
            config.Routes.MapHttpRoute(
                name:"searhMovie",
                routeTemplate: "api/movie/{param}", new {controller="movies",action= "GetSearchMovie" }
                );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
