using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IoCConteiners.Models;
using IoCConteiners.Resipository;
using IoCConteiners.Resipository.Implementation;

namespace IoCContainers.CastelWindsor.Container
{
	public class BusinessLogicInstaller : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Component.For<IRepository<User>>().ImplementedBy<JsonRepository<User>>());
		}
	}
}