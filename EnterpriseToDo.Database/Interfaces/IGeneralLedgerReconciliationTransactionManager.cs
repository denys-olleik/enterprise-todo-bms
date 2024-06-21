using EnterpriseToDo.Business;

namespace EnterpriseToDo.Database.Interfaces
{
  public interface IGeneralLedgerReconciliationTransactionManager : IGenericRepository<GeneralLedgerReconciliationTransaction, int>
  {
    Task<List<GeneralLedgerReconciliationTransaction>> GetLastTransactionAsync(int reconciliationTransactionId, int organizationId, bool loadChildren = false);
  }
}