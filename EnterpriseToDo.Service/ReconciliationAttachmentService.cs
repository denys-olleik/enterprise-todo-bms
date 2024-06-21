using EnterpriseToDo.Business;
using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
  public class ReconciliationAttachmentService
  {
    public async Task<ReconciliationAttachment> CreateAsync(ReconciliationAttachment attachment)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.ReconiliationAttachmentManager().CreateAsync(attachment);
    }

    public async Task<ReconciliationAttachment> GetAsync(int reconciliationAttachmentId, int organizationId)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.ReconiliationAttachmentManager().GetAsync(reconciliationAttachmentId, organizationId);
    }

    public async Task<ReconciliationAttachment> GetByReconciliationIdAsync(int reconciliationId, int organizationId)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.ReconiliationAttachmentManager().GetByReconciliationIdAsync(reconciliationId, organizationId);
    }

    public async Task<int> UpdateFilePathAsync(int id, string destinationPath, int organizationId)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.ReconiliationAttachmentManager().UpdateFilePathAsync(id, destinationPath, organizationId);
    }

    public async Task<int> UpdateReconciliationIdAsync(int id, int reconciliationId, int organizationId)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.ReconiliationAttachmentManager().UpdateReconciliationIdAsync(id, reconciliationId, organizationId);
    }
  }
}