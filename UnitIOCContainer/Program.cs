using UnitIOCContainer.UnitOfWork;

namespace UnitIOCContainer
{
   internal class Program
   {
      private static IUnitOfWork _unitOfWork;
      private static UnityContainerResolver _resolver;

      static void Main(string[] args)
      {
         _resolver = new UnityContainerResolver();

         Console.WriteLine($"\n-----------------------------Employee Record-----------------------------");
         ShowEmployee();
         Console.ReadLine();
      }

      static void ShowEmployee()
      {
         _unitOfWork = (IUnitOfWork)_resolver.Resolver();

         var emp = _unitOfWork.EmployeeRepository.GetByID(1);
         Console.WriteLine($"Employee Name: {emp.FirstName} " + $"{emp.LastName}, Employee Email: {emp.EmailAddress} ");
      }
   }
}