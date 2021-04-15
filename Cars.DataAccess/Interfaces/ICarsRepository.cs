using Cars.Models.Entities;
using System.Collections.Generic;

namespace Cars.DataAccess.Interfaces
{
	public interface ICarsRepository : IEntityRepositoryBase<Car>
	{
		List<Car> Filter(int pageNumber, int pageSize);
	}
}
