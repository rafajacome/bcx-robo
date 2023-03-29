using Owin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace Qyon.AdventureServices
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            app.UseWebApi(config);
        }
    }
}
