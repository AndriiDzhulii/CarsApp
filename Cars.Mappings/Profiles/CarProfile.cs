using AutoMapper;
using Cars.Models.Entities;
using Cars.Models.Models;

namespace Cars.Mappings.Profiles
{
	public class CarProfile : Profile
	{
		public CarProfile()
		{
			CreateMap<Car, CarModel>();
			CreateMap<CarAttribute, CarAttributeModel>();
			CreateMap<CarAttributeType, CarAttributeTypeModel>();

			CreateMap<CarModel, Car>()
						.ForMember(e => e.Id, e => e.Ignore())
						.ForMember(e => e.Engine, e => e.Ignore())
						.ForMember(e => e.Battery, e => e.Ignore())
						.ForMember(e => e.Manufacturer, e => e.Ignore())
						.ForMember(e => e.EngineId, e => e.MapFrom(f => f.Engine.Id))
						.ForMember(e => e.BatteryId, e => e.MapFrom(f => f.Battery.Id))
						.ForMember(e => e.ManufacturerId, e => e.MapFrom(f => f.Manufacturer.Id));

			CreateMap<CarAttributeModel, CarAttribute>();
			CreateMap<CarAttributeTypeModel, CarAttributeType>();
		}
	}
}
