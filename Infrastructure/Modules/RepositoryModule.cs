using Ninject.Modules;
using Services.Interfaces;

namespace Infrastructure.Modules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(StudentRecordRepo<>));
        }
    }
}
