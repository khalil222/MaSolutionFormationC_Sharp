﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Banking.BackOffice
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //Configurer la serialisation selon le Camel casing

            //Activer CORS
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
