using Cars.DataAccess.Interfaces;

namespace Cars.DataAccess.Repositories
{
	public abstract class RepositoryBase
    {
        public IApplicationDbContext DbContext { get; private set; }

        public RepositoryBase(IApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
