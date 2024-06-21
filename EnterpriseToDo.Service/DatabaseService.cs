using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
  public class DatabaseService
  {
    public async Task ResetDatabase()
    {
      FactoryManager factoryManager = new FactoryManager();
      await factoryManager.GetDatabaseManager().ResetDatabaseAsync();
    }
  }
}