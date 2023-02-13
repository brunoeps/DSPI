using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BuffetManagement
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que é executado na inicialização do aplicativo
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Log.Logger = new LoggerConfiguration()
               .WriteTo.File("C:\\temp\\myapp.txt",
               restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information,
               rollingInterval: RollingInterval.Hour)
               .CreateLogger();

        }
    }
}