﻿using EnterpriseToDo.Business;
using EnterpriseToDo.Database;

namespace EnterpriseToDo.Service
{
  public class InvoiceLineService
  {
    public async Task<InvoiceLine> CreateAsync(InvoiceLine invoiceLine)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.GetInvoiceLineManager().CreateAsync(invoiceLine);
    }

    public async Task<int> DeleteByInvoiceIdAsync(int invoiceId, int organizationId)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.GetInvoiceLineManager().DeleteByInvoiceIdAsync(invoiceId, organizationId);
    }


    /// <summary>
    /// This method exists to warn developers to use another method.
    /// This was done to prevent an existence of a method in multiple places of the with the same implementation.
    /// </summary>
    /// <param name="invoiceId"></param>
    /// <param name="organizationId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<List<InvoiceLine>> 
      GetByInvoiceIdAsync(int invoiceId, int organizationId)
    {
      throw new NotImplementedException(
        "Do not implement this method. " +
        "Use generalLedgerInvoiceInvoiceLineService.GetByInvoiceIdAsync");

      //GeneralLedgerInvoiceInvoiceLineService generalLedgerInvoiceInvoiceLineService
      //  = new GeneralLedgerInvoiceInvoiceLineService(this, new GeneralLedgerService());
      //return await generalLedgerInvoiceInvoiceLineService.GetByInvoiceIdAsync(invoiceId, organizationId, true);
    }

    public async Task<int> UpdateAsync(InvoiceLine line, int organizationId)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.GetInvoiceLineManager().UpdateAsync(line, organizationId);
    }

    public async Task<int> UpdateTitleAndDescription(List<InvoiceLine> invoiceLines, int invoiceID, int userId, int organizationId)
    {
      FactoryManager factoryManager = new FactoryManager();
      return await factoryManager.GetInvoiceLineManager().UpdateTitleAndDescription(invoiceLines, invoiceID, userId, organizationId);
    }
  }
}