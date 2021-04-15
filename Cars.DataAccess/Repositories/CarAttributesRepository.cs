using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Cars.DataAccess.Repositories
{
	public class CarAttributesRepository : EntityRepositoryBase<CarAttribute>, ICarsAttributesRepository
	{
		public CarAttributesRepository(IApplicationDbContext dbContext) : base(dbContext)
		{

		}

		public List<CarAttribute> FilterByType(string typeName)
		{
			return DbContext.CarAttributes.Where(e => e.Type.Name == typeName).ToList();
		}
	}
}
