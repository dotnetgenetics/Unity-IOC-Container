using UnitIOCContainer.Models;

namespace UnitIOCContainer.Repository
{
   public class GenericRepository<T> : IRepository<T> where T : class
   {
      private ContosoRetailDwContext _context;

      public GenericRepository()
      {
         this._context = new ContosoRetailDwContext();
      }

      public T GetByID(int Id)
      {
         return _context.Set<T>().Find(Id);
      }
   }
}
