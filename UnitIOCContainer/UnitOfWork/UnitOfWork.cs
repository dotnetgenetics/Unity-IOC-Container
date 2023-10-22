using UnitIOCContainer.Repository;

namespace UnitIOCContainer.UnitOfWork
{
   public class UnitOfWork : IUnitOfWork
   {
      public IEmployeeRepository EmployeeRepository { get; private set; }

      public UnitOfWork(IEmployeeRepository employeeRepository)
      {
         EmployeeRepository = employeeRepository;
      }
   }
}
