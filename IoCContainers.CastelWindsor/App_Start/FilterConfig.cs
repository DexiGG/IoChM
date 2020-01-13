using System.Web;
using System.Web.Mvc;

namespace IoCContainers.CastelWindsor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
