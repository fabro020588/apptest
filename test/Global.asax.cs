using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using test.Handler;

namespace test
{
  public class WebApiApplication : HttpApplication
  {
    protected void Application_Start()
    {
      GlobalConfiguration.Configure(WebApiConfig.Register);
      GlobalConfiguration.Configuration.MessageHandlers.Add(new MessageHandler());
    }
  }
}
