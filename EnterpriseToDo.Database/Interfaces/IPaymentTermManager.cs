using EnterpriseToDo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseToDo.Database.Interfaces
{
    public interface IPaymentTermManager : IGenericRepository<PaymentTerm, int>
    {
        Task<List<PaymentTerm>> GetAllAsync();
        Task<PaymentTerm?> GetAsync(int paymentTermId);
    }
}