using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace IoCContainers.CastelWindsor.Container
{
	public class ControllersInstaller : IWindsorInstaller
	{
		[System.Obsolete]
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(AllTypes.FromThisAssembly()
				.Pick().If(t => t.Name.EndsWith("Controller"))
				.Configure(configurer => configurer.Named(configurer.Implementation.Name))
				.LifestylePerWebRequest());
		}
	}
}