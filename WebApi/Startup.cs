using Biz;
using Dac.Repositories;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApi.Startup))]
namespace WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureRoutes(config);

            // create biz layer dependencies
            var shopify = new ShopifyDac("<shop-url>", "<token>");
            var db = new SqlServerDac("<connection-string>");
            var biz = new ShopifyBiz(shopify, db);
            config.DependencyResolver = new SimpleResolver(biz);

            app.UseWebApi(config);
        }

        private void ConfigureRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
