using Ninject.Syntax;

namespace CarsApp.Infrastructure
{
	public static class DependencyResolver
	{
		public static IResolutionRoot Resolver { get; set; }
	}
}