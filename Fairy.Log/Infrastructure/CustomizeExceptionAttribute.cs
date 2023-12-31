using log4net;
using System.Web.Mvc;

namespace Fairy.Log.Infrastructure
{
    public class CustomizeExceptionAttribute: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //记录错误信息
            ILog log = LogManager.GetLogger(typeof(CustomizeExceptionAttribute).FullName);
            log.Error(filterContext.Exception.ToString());
            //让当前请求 跳转到首页，或者错误页面
            filterContext.HttpContext.Response.Redirect("https://localhost/error");
            filterContext.ExceptionHandled = true;

            base.OnException(filterContext);

        }
    }
}