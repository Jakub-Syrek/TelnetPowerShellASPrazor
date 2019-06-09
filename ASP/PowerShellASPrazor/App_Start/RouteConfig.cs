using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PowerShellASPrazor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional  }
            );
            routes.MapRoute(
                name: "Test",
                url: "Home/Test/{IP1}/{SOURCEIP1}/{PORT1}",
                defaults: new { controller = "Home", action = "Test", IP1 = UrlParameter.Optional, SOURCEIP1 = UrlParameter.Optional, PORT1 = UrlParameter.Optional,  }
            );
            routes.MapRoute(
                name: "Test2",
                url: "Home/Test/{Results}",
                defaults: new { controller = "Home", action = "Test", Results = UrlParameter.Optional }
            );
            

        }
    }
}
