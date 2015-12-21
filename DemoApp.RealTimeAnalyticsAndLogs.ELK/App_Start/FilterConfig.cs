using System.Web;
using System.Web.Mvc;

namespace DemoApp.RealTimeAnalyticsAndLogs.ELK
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}