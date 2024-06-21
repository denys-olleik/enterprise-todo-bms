﻿using EnterpriseToDo.Business;

namespace EnterpriseToDo.Database.Interfaces
{
    public interface IReconciliationManager : IGenericRepository<Reconciliation, int>
    {
        Task<List<Reconciliation>> GetAllDescendingAsync(int top, int organizationId);
        Task<Reconciliation> GetByIdAsync(int id, int organizationId);
    }
}