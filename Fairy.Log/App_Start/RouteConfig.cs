using System.Web.Mvc;
using System.Web.Routing;

namespace Fairy.Log
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);


            routes.MapRoute(
                name: "error",
                url: "error",
                defaults: new { controller = "Error", action = "Index" }
            );


            routes.MapRoute(
                name: "v1",
                url: "v1/{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Fairy.Log.Controllers.V1" }
            );

            routes.MapRoute(
                name: "v2",
                url: "v2/{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Fairy.Log.Controllers.V2" }
            );
        }
    }
}
