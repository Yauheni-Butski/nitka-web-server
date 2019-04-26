using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NitkaWebServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //TODO. Replace for real prod. origin
            var corsAttr = new EnableCorsAttribute("http://localhost:4200", "*", "*");
            config.EnableCors(corsAttr);
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
