using System;
using System.Reflection;
using System.Web.Mvc;
using Fairy.Log.Infrastructure;

namespace Fairy.Log.Controllers.V2
{
    [RoutePrefix("v2/")]
    [CustomizeException]
    public class HomeController : Controller
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);

        // GET: Home
        public ActionResult Index()
        {
            Log.Info("log日志信息");
            Log.Debug("debug信息");
            Log.Error("error信息");
            Log.Warn("warn信息");
            Exception ex = new Exception("测试的异常信息");
            Log.Fatal("fatal信息", ex);
            return Content("Hello World");
        }

        public ActionResult About()
        {
            throw new Exception("Hello Exception");
        }
    }
}