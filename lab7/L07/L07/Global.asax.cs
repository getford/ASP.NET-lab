using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace L07
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public override string GetVaryByCustomString(HttpContext context, string arg)
        {
            // Проверить запрашиваемый тип кэширования
            if (arg == "browser")
            {
                // Определить текущий браузер
                string browserName;
                browserName = Context.Request.Browser.Browser;
                browserName += Context.Request.Browser.MajorVersion.ToString();

                // Указать, что эта строка должна применяться для варьирования кэша
                return browserName;
            }
            else
            {
                return base.GetVaryByCustomString(context, arg);
            }
        }
    }
}