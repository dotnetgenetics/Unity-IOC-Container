using UnitIOCContainer.Repository;
using UnitIOCContainer.UnitOfWork;
using Unity;

namespace UnitIOCContainer
{
   public class UnityContainerResolver
   {
      private UnityContainer container;

      public UnityContainerResolver()
      {
         container = new UnityContainer();
         RegisterTypes();
      }

      public void RegisterTypes()
      {
         container.RegisterType(typeof(IRepository<>), typeof(GenericRepository<>));
         container.RegisterType<IEmployeeRepository, EmployeeRepository>();
         container.RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
      }

      public UnitOfWork.UnitOfWork Resolver()
      {
         return container.Resolve<UnitOfWork.UnitOfWork>();
      }
   }
}
