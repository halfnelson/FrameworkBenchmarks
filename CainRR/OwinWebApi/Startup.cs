using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Host.HttpListener;
using Owin;

namespace OwinWebApi
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {

            var owinHttpListener = (OwinHttpListener)appBuilder.Properties["Microsoft.Owin.Host.HttpListener.OwinHttpListener"];
            //Default for maxAccepts = 5 * ProcCount
            //Default for maxRequests = Int32.MaxValue;
            owinHttpListener.SetRequestProcessingLimits(20, Int32.MaxValue);


            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{action}",
                defaults: new { controller="Techempower" }
            );

            appBuilder.UseWebApi(config);
        }
    } 
}
