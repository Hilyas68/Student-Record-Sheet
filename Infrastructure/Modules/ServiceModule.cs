using Ninject.Modules;
using Services;
using Services.Interfaces;

namespace Infrastructure.Modules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServices<>)).To(typeof(RecordSheetService<>)).WithConstructorArgument(typeof(IRepository<>));
        }
    }
}
