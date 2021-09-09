using System.Web;
using System.Web.Mvc;

namespace Carlos_Alejandro_Nuñez_Leiva
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
