using System.Web;
using System.Web.Mvc;

namespace IoCConteiners.Ninject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
