using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Diagnostics;
using System.Web.Routing;


namespace Mod02_01
{
   public  class LoginActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            // Debug.WriteLine("This Event Fired:OnActionExecuting");
            Log("Action before", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
         //   Debug.WriteLine("This Event Fired:OnActionExecuted");
            Log("Action after", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            //  Debug.WriteLine("This Event Fired:OnResultExecuting");
            Log("Result before", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            //  Debug.WriteLine("This Event Fired:OnResultExecuted");
            Log("Result after", filterContext.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("{0} controll:{1}, action:{2}", methodName, controllerName, actionName);
            Debug.WriteLine(message);
        }

    }
}
