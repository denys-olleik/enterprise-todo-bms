using EnterpriseToDo.Business;
using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
  public class InventoryLedgerService
  {
    public async Task<InventoryLedger> CreateAsync(InventoryLedger inventoryLedger)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.GetInventoryLedgerManager().CreateAsync(inventoryLedger);
    }
  }
}