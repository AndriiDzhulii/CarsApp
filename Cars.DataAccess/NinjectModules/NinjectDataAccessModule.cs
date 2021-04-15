using Cars.DataAccess.Interfaces;
using Cars.DataAccess.Repositories;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Cars.DataAccess.NinjectModules
{
    public class NinjectDataAccessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplicationDbContext>().To<ApplicationDbContext>().InRequestScope();
            Bind<ICarsRepository>().To<CarRepository>().InRequestScope();
            Bind<ICarsAttributesRepository>().To<CarAttributesRepository>().InRequestScope();
            Bind<ICarsAttributeTypesRepository>().To<CarAttributeTypesRepository>().InRequestScope();
        }
    }
}
