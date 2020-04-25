using System.Web.Http;

namespace test
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(name: "Test", routeTemplate: "message");
    }
  }
}
