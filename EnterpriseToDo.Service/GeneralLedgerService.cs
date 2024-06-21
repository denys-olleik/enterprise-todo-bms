using EnterpriseToDo.Business;
using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
    public class GeneralLedgerService
    {
        public async Task<GeneralLedger> CreateAsync(GeneralLedger generalLedger)
        {
            FactoryManager factoryManager = new FactoryManager();
            return await factoryManager.GetGeneralLedgerManager().CreateAsync(generalLedger);
        }

        public async Task<GeneralLedger> GetAsync(int generalLedgerId, int organizationId)
        {
            FactoryManager factoryManager = new FactoryManager();
            return await factoryManager.GetGeneralLedgerManager().GetAsync(generalLedgerId, organizationId);
        }

        public async Task<List<GeneralLedger>> GetLedgerEntriesAsync(int[] ledgerContextIds, int organizationId)
        {
            FactoryManager factoryManager = new FactoryManager();
            return await factoryManager.GetGeneralLedgerManager().GetLedgerEntriesAsync(ledgerContextIds, organizationId);
        }
    }
}