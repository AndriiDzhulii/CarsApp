using Cars.Services.Interfaces;
using Ninject;
using System.Collections;

namespace CarsApp.Infrastructure.DataSources
{
	public static class CarAttributesDataSource
	{
		public static ICollection GetEngines()
		{
			return CarAttributesService().GetEngines();
		}

		public static ICollection GetBatteries()
		{
			return CarAttributesService().GetBatteries();
		}

		public static ICollection GetManufactures()
		{
			return CarAttributesService().GetManufactures();
		}

		private static ICarAttributesService CarAttributesService()
		{
			return DependencyResolver.Resolver.Get<ICarAttributesService>();
		}
	}
}