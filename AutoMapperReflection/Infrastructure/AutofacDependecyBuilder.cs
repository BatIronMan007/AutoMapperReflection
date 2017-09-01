using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using AutoMapperCommon.Infrastructure;
using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace AutoMapperReflection.Infrastructure
{
    public static class AutofacDependecyBuilder
    {

        public static void DependencyBuilder()
        {
            // Create the builder with which components/services are registered.
            var builder = new ContainerBuilder();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                                      .Where(t => t.GetCustomAttribute<InjectableAttribute>() != null)
                                      .AsImplementedInterfaces()
                                      .InstancePerRequest();

            //Creating an Instance for the Mapper
            //builder.RegisterInstance(new AutoMapperConfiguration().Configure()).As<IMapper>();

            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            //Build the Container
            var container = builder.Build();

            //Create the Dependency Resolver
            var resolver = new AutofacWebApiDependencyResolver(container);

            //COnfiguring WebApi with Dependency Resolver
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

        }
    }
}