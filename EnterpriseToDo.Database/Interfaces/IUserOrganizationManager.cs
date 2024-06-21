using EnterpriseToDo.Business;

namespace EnterpriseToDo.Database.Interfaces
{
    public interface IUserOrganizationManager : IGenericRepository<UserOrganization, int>
    {
        Task<UserOrganization> GetAsync(int userId, int organizationId);
        Task<List<Organization>> GetByUserIdAsync(int userId);
    }
}