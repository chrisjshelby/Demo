using Demo.WebApp.Data;
using Demo.WebApp.Migrations;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Demo.WebApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DemoContext, Configuration>());

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}