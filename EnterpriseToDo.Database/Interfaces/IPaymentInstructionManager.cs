using EnterpriseToDo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseToDo.Database.Interfaces
{
    public interface IPaymentInstructionManager : IGenericRepository<PaymentInstruction, int>
    {
        Task<List<PaymentInstruction>> GetAllAsync(int organizationId);
    }
}