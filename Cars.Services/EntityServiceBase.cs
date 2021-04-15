using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;
using Cars.Services.Interfaces;
using System.Collections.Generic;

namespace Cars.Services
{
	public class EntityServiceBase<TEntity, TReposiotry> : IEntityServiceBase<TEntity> where TEntity : EntityBase
																					   where TReposiotry : IEntityRepositoryBase<TEntity> 
	{
		protected TReposiotry Repository;

		public EntityServiceBase(TReposiotry entityRepositoryBase)
		{
			Repository = entityRepositoryBase;
		}

		public int Count()
		{
			return Repository.Count();
		}

		public virtual void Delete(int entityId)
		{
			Repository.Delete(entityId);
		}

		public virtual List<TEntity> GetAll()
		{
			return Repository.GetAll();
		}

		public virtual int GetNewId()
		{
			return Repository.GetNewId();
		}
	}
}
