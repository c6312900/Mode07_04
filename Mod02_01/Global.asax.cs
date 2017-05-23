using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Mod02_01.DAL;
using System.Data.Entity;

namespace Mod02_01
{
    public class MvcApplication : System.Web.HttpApplication
    {    
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

           Database.SetInitializer<OperaContext>(new OperasInitializer());

            GlobalFilters.Filters.Add(new LoginActionFilter());
        }
    }
}
