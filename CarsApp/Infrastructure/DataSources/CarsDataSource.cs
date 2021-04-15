using Cars.Services.Interfaces;
using Ninject;
using System.Collections;

namespace CarsApp.Infrastructure.DataSources
{
	public static class CarsDataSource
	{
		public static ICollection Get(int startRow, int pageSize)
		{
			var pageNumber = startRow / pageSize;

			var result = CarsService().Filter(pageNumber, pageSize);

			return result;
		}

		public static void Update(int id)
		{

		}

		public static void Delete(int id)
		{
			CarsService().Delete(id);
		}

		public static int GetTotalCount()
		{
			var result = CarsService().Count();

			return result;
		}

		private static ICarsService CarsService()
		{
			return DependencyResolver.Resolver.Get<ICarsService>();
		}
	}
}