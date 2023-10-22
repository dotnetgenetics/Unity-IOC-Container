using UnitIOCContainer.Repository;

namespace UnitIOCContainer.UnitOfWork
{
   public interface IUnitOfWork
   {
      IEmployeeRepository EmployeeRepository { get; }
   }
}
