using Autofac;
using Autofac.Integration.Mvc;
using IoCConteiners.Models;
using IoCConteiners.Resipository;
using IoCConteiners.Resipository.Implementation;
using System.Web.Mvc;

namespace IoConteiners.Autofac.Module
{
    public class AModule
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlRepository<User>>().As<IRepository<User>>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}