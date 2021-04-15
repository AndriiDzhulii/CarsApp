using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Cars.DataAccess.Repositories
{
	public abstract class EntityRepositoryBase<T> : RepositoryBase, IEntityRepositoryBase<T> where T : EntityBase
	{
		public EntityRepositoryBase(IApplicationDbContext dbContext) : base(dbContext)
		{

		}

		public virtual T Update(T entity)
		{
			DbContext.SaveChanges();

			return entity;
		}

		public virtual T Create(T entity)
		{
			DbContext.Set<T>().Add(entity);

			DbContext.SaveChanges();

			return entity;
		}

		public virtual T GetById(int id)
		{
			var entity = DbContext.Set<T>().FirstOrDefault(e => e.Id == id);

			return entity;
		}

		public virtual List<T> GetAll()
		{
			var result = DbContext.Set<T>().ToList();

			return result;
		}

		public virtual int Count()
		{
			var result = DbContext.Set<T>().Count();

			return result;
		}

		public virtual void Delete(int entityId)
		{
			var entity = DbContext.Set<T>().FirstOrDefault(e => e.Id == entityId);
			if (entity != null)
			{
				DbContext.Set<T>().Remove(entity);
				DbContext.SaveChanges();
			}
		}

		public int GetNewId()
		{
			return DbContext.Set<T>().Max(e => e.Id) + 1;
		}
	}
}
