using Cars.Models.Entities;
using System.Collections.Generic;

namespace Cars.DataAccess.Interfaces
{
	public interface ICarsAttributesRepository : IEntityRepositoryBase<CarAttribute>
	{
		List<CarAttribute> FilterByType(string typeName);
	}
}
