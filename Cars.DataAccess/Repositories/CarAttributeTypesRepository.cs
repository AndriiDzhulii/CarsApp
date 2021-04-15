using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;

namespace Cars.DataAccess.Repositories
{
	public class CarAttributeTypesRepository : EntityRepositoryBase<CarAttributeType>, ICarsAttributeTypesRepository
	{
		public CarAttributeTypesRepository(IApplicationDbContext dbContext) : base(dbContext)
		{

		}
	}
}
