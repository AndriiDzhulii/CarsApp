using Cars.Models.Entities;
using Cars.Models.Models;
using System.Collections.Generic;

namespace Cars.Services.Interfaces
{
	public interface ICarAttributesService : IEntityServiceBase<CarAttribute>
	{
		List<CarAttributeModel> GetEngines();
		List<CarAttributeModel> GetBatteries();
		List<CarAttributeModel> GetManufactures();
	}
}
