using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;
using System.Data.Entity;

namespace Cars.DataAccess
{
	public class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		public DbSet<Car> Cars { get; set; }
		public DbSet<CarAttribute> CarAttributes { get; set; }
		public DbSet<CarAttributeType> CarAttributeTypes { get; set; }

		public ApplicationDbContext():base("ApplicationDbContext")
		{
			Database.SetInitializer<ApplicationDbContext>(null);
		}
	}
}
