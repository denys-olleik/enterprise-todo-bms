namespace EnterpriseToDo.Common
{
  public interface IIdentifiable<out TKey>
  {
    TKey Identifiable { get; }
  }
}