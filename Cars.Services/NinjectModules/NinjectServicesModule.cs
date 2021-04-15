using Cars.Services.Interfaces;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Cars.Services.NinjectModules
{
	public class NinjectServicesModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ICarsService>().To<CarsService>().InRequestScope();
			Bind<ICarAttributesService>().To<CarAttributesService>().InRequestScope();
		}
	}
}
