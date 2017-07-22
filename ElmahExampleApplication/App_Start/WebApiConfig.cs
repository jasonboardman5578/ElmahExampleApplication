using Elmah.Contrib.WebApi;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace ElmahExampleApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Add(typeof(IExceptionLogger), new ElmahExceptionLogger());
        }
    }
}
