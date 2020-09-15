using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FinalFruitManager
{
    class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            HttpConfiguration configuration = new HttpConfiguration();
            addRoutes(configuration);
            app.UseWebApi(configuration);
        }

        public static void addRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
