using EnterpriseToDo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseToDo.Database.Interfaces
{
    public interface IInvitationManager : IGenericRepository<Invitation, int>
    {
        Task<int> DeleteAsync(Guid guid);
        Task<Invitation> GetAsync(Guid guid);
    }
}