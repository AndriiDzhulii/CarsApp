using Cars.Models.Entities;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Cars.DataAccess.Interfaces
{
    public interface IApplicationDbContext
    {
        Database Database { get; }

        DbSet<Car> Cars { get; set; }

        DbSet<CarAttribute> CarAttributes { get; set; }

        DbSet<CarAttributeType> CarAttributeTypes { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
