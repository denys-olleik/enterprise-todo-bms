using EnterpriseToDo.Business;

namespace EnterpriseToDo.Database.Interfaces
{
  public interface IReconciliationExpenseManager : IGenericRepository<ReconciliationExpense, int>
  {
    Task<ReconciliationExpense> GetAsync(int reconciliationTransactionID);
    Task<int> UpdateAmountAsync(int expenseId, decimal? amount);
    Task<int> UpdateAsync(ReconciliationExpense expense);
  }
}