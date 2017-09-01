using AutoMapperReflection.Infrastructure;
using System.Web.Http;

namespace AutoMapperReflection
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacDependecyBuilder.DependencyBuilder();
        }
    }
}
