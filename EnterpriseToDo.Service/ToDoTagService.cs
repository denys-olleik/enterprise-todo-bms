using EnterpriseToDo.Business;
using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
  public class ToDoTagService
  {
    public async Task<ToDoTag> CreateAsync(ToDoTag taskTag)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.GetTaskTagManager().CreateAsync(taskTag);
    }
  }
}