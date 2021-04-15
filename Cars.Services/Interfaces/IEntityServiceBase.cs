using Cars.Models.Entities;
using System.Collections.Generic;

namespace Cars.Services.Interfaces
{
	public interface IEntityServiceBase<TEntity> where TEntity : EntityBase
	{
		void Delete(int entityId);

		int Count();

		List<TEntity> GetAll();
    }
}
