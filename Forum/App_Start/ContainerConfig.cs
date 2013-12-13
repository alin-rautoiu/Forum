using Autofac;
using Autofac.Integration.Mvc;
using Forum.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.App_Start
{
    public class DependencyConfig
    {
        public static void RegisterResolver()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryDiscussionStore>().As<IDiscussionStore>().InstancePerHttpRequest();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}