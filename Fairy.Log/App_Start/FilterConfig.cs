using System.Web.Mvc;
using Fairy.Log.Infrastructure;

namespace Fairy.Log
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            GlobalFilters.Filters.Add(new CustomizeExceptionAttribute());
        }
    }
}