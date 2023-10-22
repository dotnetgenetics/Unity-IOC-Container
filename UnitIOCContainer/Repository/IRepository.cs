namespace UnitIOCContainer.Repository
{
   public interface IRepository<T> where T : class
   {
      T GetByID(int Id);
   }
}
