﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GoodQRma
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //added for Google

            routes.MapRoute(
            name: "Google API Sign-in",
            url: "signin-google",
            defaults: new { controller = "Account", action = "ExternalLoginCallbackRedirect" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        //    routes.MapRoute(
        //name: "Poster",
        //url: "{controller}/{action}/{id}",
        //defaults: new { controller = "Event", action = "EventPoster", id = 1 }

        //);


        }
    }
}
