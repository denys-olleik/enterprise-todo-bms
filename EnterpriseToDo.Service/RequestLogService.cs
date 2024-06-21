using EnterpriseToDo.Business;
using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
  public class RequestLogService
  {
    public async Task<RequestLog> CreateAsync(RequestLog requestLog)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.GetRequestLogManager().CreateAsync(requestLog);
    }
  }
}