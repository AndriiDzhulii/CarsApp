using Cars.Models.Entities;
using Cars.Models.Models;
using System.Collections.Generic;

namespace Cars.Services.Interfaces
{
	public interface ICarsService : IEntityServiceBase<Car>
	{
		void Save(CarModel model);

		List<CarModel> Filter(int pageNumber, int pageSize);
	}
}
