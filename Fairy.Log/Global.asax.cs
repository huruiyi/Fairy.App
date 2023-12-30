using System.IO;
using System.Web.Mvc;
using System.Web.Routing;
using log4net.Config;

namespace Fairy.Log
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/log4net.config")));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
