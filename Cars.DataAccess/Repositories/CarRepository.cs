using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Cars.DataAccess.Repositories
{
	public class CarRepository : EntityRepositoryBase<Car>, ICarsRepository
	{
		public CarRepository(IApplicationDbContext dbContext) : base(dbContext)
		{
		}

		public List<Car> Filter(int pageNumber, int pageSize)
		{
			return DbContext.Cars.Include(e => e.Engine.Type)
								 .Include(e => e.Battery.Type)
								 .Include(e => e.Manufacturer.Type)
								 .OrderByDescending(e => e.Id).Skip(pageNumber * pageSize).Take(pageSize).ToList();
		}
	}
}
