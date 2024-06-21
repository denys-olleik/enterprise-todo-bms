using EnterpriseToDo.Common;

namespace EnterpriseToDo.Database
{
  public interface IGenericRepository<T, TKey> where T : IIdentifiable<TKey>
  {
    T Create(T entity);
    Task<T> CreateAsync(T entity);
    T Get(TKey id);
    IEnumerable<T> GetAll();
    int Update(T entity);
    int Delete(TKey id);
  }
}