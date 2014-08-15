using System.Web;
using System.Web.Mvc;

namespace BootsrapAce.Admin.Templet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}