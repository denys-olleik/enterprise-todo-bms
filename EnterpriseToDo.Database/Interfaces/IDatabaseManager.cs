using EnterpriseToDo.Business;

namespace EnterpriseToDo.Database.Interfaces
{
  public interface IDatabaseManager : IGenericRepository<DatabaseThing, int>
  {
    Task ResetDatabaseAsync();
  }
}