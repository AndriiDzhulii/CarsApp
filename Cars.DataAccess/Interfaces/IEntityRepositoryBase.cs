using Cars.Models.Entities;
using System.Collections.Generic;

namespace Cars.DataAccess.Interfaces
{
	public interface IEntityRepositoryBase<TEntity> where TEntity : EntityBase
    {
        TEntity Update(TEntity entity);

        TEntity Create(TEntity entity);

        TEntity GetById(int id);

        int GetNewId();

        List<TEntity> GetAll();

        int Count();

        void Delete(int entityId);
    }
}
