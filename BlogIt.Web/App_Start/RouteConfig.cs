﻿using System.Web.Mvc;
using System.Web.Routing;

namespace BlogIt.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "NewPost",
                url: "{controller}/{action}/{authorID}/{blogID}"
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "home", action = "cover", id = UrlParameter.Optional }
            );
        }
    }
}
