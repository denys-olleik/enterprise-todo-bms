using EnterpriseToDo.Business;

namespace EnterpriseToDo.Database.Interfaces
{
  public interface IReconciliationExpenseCategoryManager : IGenericRepository<ReconciliationExpenseCategory, int>
  {
    Task<List<ReconciliationExpenseCategory>> GetAllAsync(int organizationId);
    Task<ReconciliationExpenseCategory> GetAsync(int reconciliationExpenseCategoryId);
  }
}