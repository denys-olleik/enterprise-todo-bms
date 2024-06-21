using EnterpriseToDo.Common;

namespace EnterpriseToDo.Business
{
  public class DatabaseThing : IIdentifiable<int>
  {
    public int DatabaseID { get; set; }

    public int Identifiable => this.DatabaseID;
  }
}