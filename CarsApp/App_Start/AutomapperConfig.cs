using AutoMapper;
using Cars.Mappings.Profiles;

namespace CarsApp.App_Start
{
	public class AutomapperConfig
	{
		public IMapper Setup()
		{
			var configuration = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new CarProfile());
			});

			return configuration.CreateMapper();
		}
	}
}