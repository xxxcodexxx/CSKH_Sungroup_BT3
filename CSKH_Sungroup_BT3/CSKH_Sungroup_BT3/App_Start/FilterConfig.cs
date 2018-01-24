using System.Web;
using System.Web.Mvc;

namespace CSKH_Sungroup_BT3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
