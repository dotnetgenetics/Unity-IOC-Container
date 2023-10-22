using UnitIOCContainer.Models;

namespace UnitIOCContainer.Repository
{
   public class EmployeeRepository : GenericRepository<DimEmployee>, IEmployeeRepository
   {
      public EmployeeRepository()
      { }
   }
}
