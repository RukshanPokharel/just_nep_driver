using Autofac;
using Autofac.Integration.WebApi;
using DriverApplication.Repositories;
using DriverApplication.Services;
using DriverApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DriverApplication.App_Start
{
    public class AutofacConfig
    {
        public static void config()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());    //Register WebApi Controllers
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DriverServices>().As<IDriverService>().InstancePerRequest();
            builder.RegisterType<DriverRepository>().As<IDriverRepository>().InstancePerRequest();
            builder.RegisterType<DriverTasksRepository>().As<IDriverTasksRepository>().InstancePerRequest();

            // Repositories
            builder.RegisterAssemblyTypes(typeof(DriverRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            // Services
            builder.RegisterAssemblyTypes(typeof(DriverServices).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver; //Set the WebApi DependencyResolver

        }
    }
}