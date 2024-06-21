using EnterpriseToDo.Business;

namespace EnterpriseToDo.Database.Interfaces
{
  public interface IRequestLogManager : IGenericRepository<RequestLog, int>
  {
  }
}